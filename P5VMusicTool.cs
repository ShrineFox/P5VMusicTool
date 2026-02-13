using System.Drawing.Text;
using System.Security;

namespace P5VMusicTool
{
    public partial class P5VMusicTool : Form
    {

        public static Project currentProject = new Project();

        public P5VMusicTool()
        {
            InitializeComponent();
            LoadDefaultProject();
            SetupCollectionListBox();
            SetupDestinationsListBox();
            SetupSongDestListBox();
        }


        private void LoadDefaultProject()
        {
            if (File.Exists("Music.json"))
            {
                LoadProject("Music.json");
            }
        }

        private void LoadProject(string jsonPath)
        {
            throw new NotImplementedException();
        }

        private void NewProject_Click(object sender, EventArgs e)
        {
            currentProject = new Project();
        }

        BindingSource bs_Destinations = new BindingSource();

        private void SetupDestinationsListBox()
        {
            bs_Destinations.DataSource = currentProject.Destinations;
            listBox_Destinations.DataSource = bs_Destinations;
            listBox_Destinations.DisplayMember = "Name";

            if (currentProject.Destinations.Count > 0)
                listBox_Destinations.SelectedIndex = 0;
        }


        BindingSource bs_SongDestinations = new BindingSource();
        private void SetupSongDestListBox()
        {
            bs_SongDestinations.DataSource = currentProject.Destinations;
            listBox_SongDestinations.DataSource = bs_SongDestinations;
            listBox_SongDestinations.DisplayMember = "Name";
        }


        BindingSource bs_Collection = new BindingSource();

        private void SetupCollectionListBox()
        {
            bs_Collection.DataSource = currentProject.Collections;
            listBox_Collections.DataSource = bs_Collection;
            listBox_Collections.DisplayMember = "Name";

            if (currentProject.Collections.Count > 0)
                listBox_Collections.SelectedIndex = 0;
        }

        private void Collection_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetupSongListBox();
        }

        BindingSource bs_Songs = new BindingSource();

        private void SetupSongListBox()
        {
            SongCollection selectedCollection = (SongCollection)listBox_Collections.SelectedItem;

            if (selectedCollection == null)
                return;

            bs_Songs.DataSource = selectedCollection.Songs;
            listBox_Songs.DataSource = bs_Songs;
            listBox_Songs.DisplayMember = "Name";

            bs_Collection.ResetBindings(false); // update UI

            if (selectedCollection.Songs.Count > 0)
                listBox_Songs.SelectedIndex = 0;
        }

        private void Song_SelectedIndexChanged(object sender, EventArgs e)
        {
            Song selectedSong = (Song)listBox_Songs.SelectedItem;
            if (selectedSong == null)
                return;
            SongCollection selectedCollection = (SongCollection)listBox_Collections.SelectedItem;

            txt_SongName.Text = selectedSong.Name;
            txt_SongLocation.Text = selectedSong.Path;
            num_SongCueID.Value = selectedSong.ID;
            bs_SongDestinations.DataSource = selectedSong.DestinationNames;
            bs_SongDestinations.ResetBindings(false); // update UI
        }

        private void AddCollection_Click(object sender, EventArgs e)
        {
            AddCollection();
        }

        private void RemoveCollection_Click(object sender, EventArgs e)
        {
            RemoveCollection();
        }

        private void RemoveCollection()
        {
            SongCollection selectedCollection = (SongCollection)listBox_Collections.SelectedItem;

            if (selectedCollection == null) return;

            currentProject.Collections.Remove(selectedCollection);
            bs_Collection.ResetBindings(false); // update UI
        }

        private void AddCollection()
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.Description = "Select folder where songs are saved to";
            folderBrowser.UseDescriptionForTitle = true;

            var rslt = folderBrowser.ShowDialog();
            if (rslt == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
            {
                currentProject.Collections.Add(new SongCollection() { Name = Path.GetFileName(folderBrowser.SelectedPath), Path = folderBrowser.SelectedPath });
                foreach (var adx in Directory.GetFiles(folderBrowser.SelectedPath, "*.adx", SearchOption.TopDirectoryOnly))
                {
                    currentProject.Collections.Last().Songs.Add(new Song() { Name = Path.GetFileNameWithoutExtension(adx), Path = adx });
                }
                bs_Collection.ResetBindings(false); // update UI
            }
        }

        public static string lastClickedListBox = "";
        private void ListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                lastClickedListBox = ((ListBox)sender).Name;

                if (lastClickedListBox == "listBox_Destinations")
                    addDestinationToSelectedSongToolStripMenuItem.Visible = true;
                else
                    addDestinationToSelectedSongToolStripMenuItem.Visible = false;

                contextMenuStrip.Show(Cursor.Position);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lastClickedListBox))
                return;

            if (lastClickedListBox == "listBox_Collections")
                AddCollection();
            else if (lastClickedListBox == "listBox_Songs")
                AddSong();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lastClickedListBox))
                return;

            if (lastClickedListBox == "listBox_Collections")
                RemoveCollection();
            else if (lastClickedListBox == "listBox_Songs")
                RemoveSong();
        }

        private void AddSong_Click(object sender, EventArgs e)
        {
            AddSong();
        }

        private void AddSong()
        {
            SongCollection selectedCollection = (SongCollection)listBox_Collections.SelectedItem;

            if (selectedCollection == null) return;

            OpenFileDialog fileDlg = new OpenFileDialog();
            fileDlg.Title = "Select Song to Add";
            fileDlg.Filter = "CRIWare Audio (*.adx)|*.exe";

            var result = fileDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectedCollection.Songs.Add(new Song() { Name = Path.GetFileNameWithoutExtension(fileDlg.FileName), Path = fileDlg.FileName });
                bs_Songs.ResetBindings(false); // update UI
            }
        }

        private void RemoveSong_Click(object sender, EventArgs e)
        {
            RemoveSong();
        }

        private void RemoveSong()
        {
            SongCollection selectedCollection = (SongCollection)listBox_Collections.SelectedItem;
            Song selectedSong = (Song)listBox_Songs.SelectedItem;
            if (selectedCollection == null || selectedSong == null) return;
            selectedCollection.Songs.Remove(selectedSong);
            bs_Songs.ResetBindings(false); // update UI
        }

        private void AddDestinationToSelectedSong_Click(object sender, EventArgs e)
        {
            AddDestinationToSelectedSong();
        }

        private void AddDestinationToSelectedSong()
        {
            Song selectedSong = (Song)listBox_Songs.SelectedItem;
            Destination selectedDestination = (Destination)listBox_Destinations.SelectedItem;
            if (selectedSong == null || selectedDestination == null) return;
            if (!selectedSong.DestinationNames.Any(x => x.Equals(selectedDestination.Name)))
            {
                selectedSong.DestinationNames.Add(selectedDestination.Name);
                bs_SongDestinations.ResetBindings(false); // update UI
            }
        }

        // TODO: Show warning when song references a destination that doesn't exist anymore

        private void CreateDestination_Click(object sender, EventArgs e)
        {
            CreateDestination();
        }

        private void CreateDestination()
        {
            currentProject.Destinations.Add(new Destination() { Name = "New Destination", CollectionPath = "" });
            bs_Destinations.ResetBindings(false); // update UI
            tabControl_Main.SelectedIndex = 1; // switch to Destinations tab
            listBox_Destinations.SelectedIndex = listBox_Destinations.Items.Count - 1; // select newly created destination
        }

        private void DeleteDestination_Click(object sender, EventArgs e)
        {
            DeleteDestination();
        }

        private void DeleteDestination()
        {
            Destination selectedDestination = (Destination)listBox_Destinations.SelectedItem;
            if (selectedDestination == null) return;
            currentProject.Destinations.Remove(selectedDestination);
            bs_Destinations.ResetBindings(false); // update UI
        }


    }

    public class Project
    {
        public List<SongCollection> Collections { get; set; } = new List<SongCollection>();
        public List<Destination> Destinations { get; set; } = new List<Destination>();
    }

    public class SongCollection
    {
        public string Name { get; set; } = "";
        public string Path { get; set; } = "";
        public List<Song> Songs { get; set; } = new List<Song>();
    }

    public class Song
    {
        public string Name { get; set; } = "";
        public string Path { get; set; } = "";
        public int ID { get; set; } = 0;
        public List<string> DestinationNames { get; set; } = new List<string>();
    }

    public class Destination
    {
        public string Name { get; set; } = "";
        public string CollectionPath { get; set; } = "";
    }
}
