using System.Drawing.Text;
using System.Security;
using Newtonsoft.Json;

namespace P5VMusicTool
{
    public partial class P5VMusicTool : Form
    {

        public static Project currentProject = new Project();

        private void NewProject_Click(object sender, EventArgs e)
        {
            currentProject = new Project();
            SetupCollectionListBox();
            SetupDestinationsListBox();
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
            public List<int> DestinationIDs { get; set; } = new List<int>();
        }

        public class Destination
        {
            [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
            public int InternalID { get; set; } = 0;
            [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
            public string Name { get; set; } = "";
            [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
            public string CostumeName { get; set; } = "";
            [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
            public int CueID { get; set; } = -1;
            [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
            public int WaveID { get; set; } = -1;
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
}
