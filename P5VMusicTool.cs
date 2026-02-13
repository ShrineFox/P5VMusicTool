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
    }
}
