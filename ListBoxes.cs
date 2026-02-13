using System.Drawing.Text;
using System.Security;
using Newtonsoft.Json;

namespace P5VMusicTool
{
    public partial class P5VMusicTool : Form
    {
        //
        // Songs Tab
        // 

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

            SetSongName();
            SetSongCueID();
            SetSongPath();
            bs_SongDestinations.DataSource = selectedSong.DestinationNames;
            bs_SongDestinations.ResetBindings(false); // update UI
        }

        BindingSource bs_SongDestinations = new BindingSource();
        private void SetupSongDestListBox()
        {
            bs_SongDestinations.DataSource = currentProject.Destinations;
            listBox_SongDestinations.DataSource = bs_SongDestinations;
            listBox_SongDestinations.DisplayMember = "Name";
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

        //
        // Destinations Tab
        //

        BindingSource bs_Destinations = new BindingSource();

        private void SetupDestinationsListBox()
        {
            bs_Destinations.DataSource = currentProject.Destinations;
            listBox_Destinations.DataSource = bs_Destinations;
            listBox_Destinations.DisplayMember = "Name";

            if (currentProject.Destinations.Count > 0)
                listBox_Destinations.SelectedIndex = 0;
        }

        private void Destinations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentProject == null)
                return;

            Destination selectedDestination = (Destination)listBox_Destinations.SelectedItem;

            if (selectedDestination == null)
                return;

            SetDestinationName();
            SetDestinationPath();
            SetDestinationCostumeName();
            SetDestChk_NormalBattle();
            SetDestChk_AmbushBattle();
            SetDestChk_PinchBattle();
            SetDestChk_BattleTalk();
            SetDestChk_BattleVictory();
        }

    }
}
