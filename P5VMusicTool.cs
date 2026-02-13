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
            SetupCollectionListBox();
        }

        BindingSource bs_Collection = new BindingSource();

        private void SetupCollectionListBox()
        {
            bs_Collection.DataSource = currentProject.Collections;
            listBox_Collections.DataSource = bs_Collection;

            if (listBox_Collections.Items.Count > 0)
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
            bs_Songs.DataSource = selectedCollection;
            listBox_Songs.DataSource = bs_Songs;

            if (listBox_Songs.Items.Count > 0)
                listBox_Songs.SelectedIndex = 0;
        }

        private void Song_SelectedIndexChanged(object sender, EventArgs e)
        {
            Song selectedSong = (Song)listBox_Songs.SelectedItem;
            SongCollection selectedCollection = (SongCollection)listBox_Collections.SelectedItem;


            txt_SongName.Text = selectedSong.Name;
            num_SongCueID.Value = selectedSong.ID;

            checkedListBox_SongDestinations.Items.Clear();

            for(int i = 0; i < currentProject.Destinations.Count; i++)
            {
                string name = currentProject.Destinations[i].Name;
                checkedListBox_SongDestinations.Items.Add(name);
                if (selectedSong.Destinations.Any(x => x.Equals(name)))
                    checkedListBox_SongDestinations.SetItemChecked(i, true);
            }
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
        public List<string> Destinations { get; set; } = new List<string>();
    }

    public class Destination
    {
        public string Name { get; set; } = "";
        public string CollectionPath { get; set; } = "";
    }
}
