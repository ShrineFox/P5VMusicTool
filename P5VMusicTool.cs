using System.Drawing.Text;
using System.Security;
using Newtonsoft.Json;

namespace P5VMusicTool
{
    public partial class P5VMusicTool : Form
    {
        public P5VMusicTool()
        {
            InitializeComponent();
            LoadDefaultProject();
            SetupCollectionListBox();
            SetupDestinationsListBox();
            SetupSongDestListBox();
        }

        private void Import_Click(object sender, EventArgs e)
        {
            currentProject.Destinations.Clear();

            var lines = File.ReadAllLines("text.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                if (Convert.ToInt32(lines[i].Split('\t')[0]) < 1000)
                    currentProject.Destinations.Add(new Destination() { Name = lines[i].Split('\t')[2], CueID = Convert.ToInt32(lines[i].Split('\t')[0]), WaveID = Convert.ToInt32(lines[i].Split('\t')[1]) });
            }


            foreach (var dir in Directory.GetDirectories("D:\\Games\\Reloaded\\Mods\\p5rpc.vinesauce\\Costumes\\Joker")
                .Where(x => x.Contains("_")))
            {
                string pmePath = Path.Combine(dir.Replace(Path.GetFileName(dir).Split('_')[1], "").Replace("_", ""), "music.pme");

                int destCount = 0;
                if (File.Exists(pmePath))
                {
                    foreach (var line in File.ReadAllLines(pmePath).Where(x => x.Contains("const ") || x.Contains("global_bgm")))
                    {
                        Destination dest = new Destination() { Name = Path.GetFileName(dir).Split('_')[1], CostumeName = Path.GetFileName(dir).Split('_')[0] };
                        currentProject.Destinations.Add(dest);
                    }
                }
            }
        }
    }
}
