using System.Drawing.Text;
using System.Security;
using Newtonsoft.Json;

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
            string json = File.ReadAllText(jsonPath);
            currentProject = JsonConvert.DeserializeObject<Project>(json);

            SetupCollectionListBox();
            SetupDestinationsListBox();
            SetupSongDestListBox();
        }

        private void NewProject_Click(object sender, EventArgs e)
        {
            currentProject = new Project();
            SetupCollectionListBox();
            SetupDestinationsListBox();
            SetupSongDestListBox();
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

            bs_Songs.ResetBindings(false); // update UI

            if (selectedCollection.Songs.Count > 0)
                listBox_Songs.SelectedIndex = 0;
        }

        private void Song_SelectedIndexChanged(object sender, EventArgs e)
        {
            SongCollection selectedCollection = (SongCollection)listBox_Collections.SelectedItem;
            if (selectedCollection == null) return;

            Song selectedSong = (Song)listBox_Songs.SelectedItem;
            if (selectedSong == null)
                return;

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


        private void Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lastClickedListBox))
                return;

            if (lastClickedListBox == "listBox_Collections")
                AddCollection();
            else if (lastClickedListBox == "listBox_Songs")
                AddSong();
            else if (lastClickedListBox == "listBox_SongDestinations")
                CreateDestination(true);
            else if (lastClickedListBox == "listBox_Destinations")
                CreateDestination();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lastClickedListBox))
                return;

            if (lastClickedListBox == "listBox_Collections")
                RemoveCollection();
            else if (lastClickedListBox == "listBox_Songs")
                RemoveSong();
            else if (lastClickedListBox == "listBox_SongDestinations")
                RemoveDestinationFromSelectedSong();
            else if (lastClickedListBox == "listBox_Destinations")
                DeleteDestination();
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
            fileDlg.Filter = "CRIWare Audio (*.adx)|*.adx";

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
                bs_SongDestinations.DataSource = selectedSong.DestinationNames;
                bs_SongDestinations.ResetBindings(false); // update UI
                tabControl_Main.SelectedIndex = 0; // switch to Songs tab
            }
        }

        // TODO: Show warning when song references a destination that doesn't exist anymore

        private void CreateDestination_Click(object sender, EventArgs e)
        {
            CreateDestination();
        }

        private void CreateDestination(bool addToCurrentSong = false)
        {
            currentProject.Destinations.Add(new Destination() { Name = "New Destination" });
            if (addToCurrentSong)
            {
                Song selectedSong = (Song)listBox_Songs.SelectedItem;
                if (selectedSong != null)
                {
                    selectedSong.DestinationNames.Add(currentProject.Destinations.Last().Name);
                    bs_SongDestinations.DataSource = selectedSong.DestinationNames;
                    bs_SongDestinations.ResetBindings(false); // update UI
                }
            }
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

        public static string lastClickedListBox = "";

        private void ContextMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var menu = (ContextMenuStrip)sender;
            Control source = menu.SourceControl;
            lastClickedListBox = source.Name;

            if (lastClickedListBox == "listBox_Destinations")
                addDestinationToSelectedSongToolStripMenuItem.Visible = true;
            else
                addDestinationToSelectedSongToolStripMenuItem.Visible = false;
        }

        private void LoadProject_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDlg = new OpenFileDialog();
            fileDlg.Title = "Choose Project to Load";
            fileDlg.Filter = "P5V Music Project (*.json)|*.json";

            var result = fileDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadProject(fileDlg.FileName);
            }
        }

        private void SaveProject_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDlg = new SaveFileDialog();
            fileDlg.Title = "Choose Where to Save Project";
            fileDlg.Filter = "P5V Music Project (*.json)|*.json";

            var result = fileDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                SaveProject(fileDlg.FileName);
            }
        }

        private void SaveProject(string jsonPath)
        {
            if (!jsonPath.ToLower().EndsWith(".json"))
                jsonPath += ".json";

            File.WriteAllText(jsonPath, JsonConvert.SerializeObject(currentProject, Newtonsoft.Json.Formatting.Indented));
        }

        private void Destinations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentProject == null)
                return;

            Destination selectedDestination = (Destination)listBox_Destinations.SelectedItem;

            if (selectedDestination == null)
                return;

            txt_DestName.Text = selectedDestination.Name;
            txt_DestLocation.Text = selectedDestination.Path;
            txt_DestCostumeName.Text = selectedDestination.CostumeName;

            chk_DestNormal.Checked = selectedDestination.NormalBattle;
            chk_DestAmbush.Checked = selectedDestination.AmbushBattle;
            chk_DestPinch.Checked = selectedDestination.PinchBattle;
            chk_DestTalk.Checked = selectedDestination.BattleTalk;
            chk_DestVictory.Checked = selectedDestination.BattleVictory;
        }

        private void AddDestToCurrentSong_Click(object sender, EventArgs e)
        {
            AddDestinationToSelectedSong();
        }

        private void RemoveDestFromCurrentSong_Click(object sender, EventArgs e)
        {
            RemoveDestinationFromSelectedSong();
        }

        private void RemoveDestinationFromSelectedSong()
        {
            Song selectedSong = (Song)listBox_Songs.SelectedItem;
            Destination selectedDestination = (Destination)listBox_Destinations.SelectedItem;
            if (selectedSong == null || selectedDestination == null) return;
            selectedSong.DestinationNames.RemoveAll(x => x.Equals(selectedDestination.Name));
            bs_SongDestinations.ResetBindings(false); // update UI
        }

        private void SongDestinations_DoubleClick(object sender, EventArgs e)
        {
            string selectedDestinationName = (string)listBox_SongDestinations.SelectedItem;
            if (string.IsNullOrEmpty(selectedDestinationName))
                return;

            if (!currentProject.Destinations.Any(x => x.Name.Equals(selectedDestinationName)))
                return;

            Destination selectedDestination = currentProject.Destinations.First(x => x.Name.Equals(selectedDestinationName));
            listBox_Destinations.SelectedItem = selectedDestination;
            tabControl_Main.SelectedIndex = 1; // switch to Destinations tab
        }
    }

    public class Project
    {
        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public List<SongCollection> Collections { get; set; } = new List<SongCollection>();
        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public List<Destination> Destinations { get; set; } = new List<Destination>();
    }

    public class SongCollection
    {
        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public string Name { get; set; } = "";
        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public string Path { get; set; } = "";
        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public List<Song> Songs { get; set; } = new List<Song>();
    }

    public class Song
    {
        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public string Name { get; set; } = "";
        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public string Path { get; set; } = "";
        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public int ID { get; set; } = 0;
        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public List<string> DestinationNames { get; set; } = new List<string>();
    }

    public class Destination
    {
        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public string Name { get; set; } = "";
        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public string Path { get; set; } = "";
        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public string CostumeName { get; set; } = "";
        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public bool NormalBattle { get; set; } = false;
        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public bool AmbushBattle { get; set; } = false;
        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public bool PinchBattle { get; set; } = false;
        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public bool BattleTalk { get; set; } = false;
        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public bool BattleVictory { get; set; } = false;
    }
}
