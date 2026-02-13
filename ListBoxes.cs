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
            SetDestCueID();
            SetDestWaveID();
            SetDestinationCostumeName();
            SetDestChk_NormalBattle();
            SetDestChk_AmbushBattle();
            SetDestChk_PinchBattle();
            SetDestChk_BattleTalk();
            SetDestChk_BattleVictory();
        }

        private void ListBox_KeyDown(object sender, KeyEventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            lastClickedListBox = listBox.Name;

            if (e.KeyCode == Keys.Delete)
            {
                if (lastClickedListBox == "listBox_Collections")
                    RemoveCollection();
                else if (lastClickedListBox == "listBox_Songs")
                    RemoveSong();
                else if (lastClickedListBox == "listBox_SongDestinations")
                    RemoveDestinationFromSelectedSong();
                else if (lastClickedListBox == "listBox_Destinations")
                    DeleteDestination();
            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Up)
                MoveSelectedItem(-1);
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Down)
                MoveSelectedItem(1);
        }

        private void MoveSelectedItem(int direction)
        {
            if (string.IsNullOrEmpty(lastClickedListBox))
                return;

            // Find the ListBox by name anywhere in the form
            var found = this.Controls.Find(lastClickedListBox, true);
            if (found == null || found.Length == 0)
                return;

            if (!(found[0] is ListBox lb))
                return;

            if (lb.SelectedIndex < 0)
                return;

            int index = lb.SelectedIndex;
            int newIndex = index + direction;

            if (newIndex < 0 || newIndex >= lb.Items.Count)
                return;

            object selected = lb.SelectedItem;

            // If the ListBox is bound via a BindingSource, manipulate the underlying list and reset bindings.
            if (lb.DataSource is BindingSource bs)
            {
                var list = bs.List as System.Collections.IList;
                if (list != null)
                {
                    list.RemoveAt(index);
                    list.Insert(newIndex, selected);
                    bs.ResetBindings(false);
                }
                else
                {
                    // Fallback to raw ListBox operations if underlying list isn't IList
                    lb.Items.RemoveAt(index);
                    lb.Items.Insert(newIndex, selected);
                }
            }

            // If the DataSource is an IList (e.g. List<T>), operate on it and reassign the DataSource to force refresh.
            else if (lb.DataSource is System.Collections.IList rawList)
            {
                rawList.RemoveAt(index);
                rawList.Insert(newIndex, selected);

                // Rebind to refresh UI (preserve object reference)
                lb.DataSource = null;
                lb.DataSource = rawList;
            }
            // Unbound ListBox
            else
            {
                lb.Items.RemoveAt(index);
                lb.Items.Insert(newIndex, selected);
            }

            lb.SelectedIndex = newIndex - direction;
            lb.Focus();
        }
    }

    public static class ControlExtensions
    {
        public static IEnumerable<Control> FlattenChildren<T>(this Control control)
        {
            return control.FlattenChildren().OfType<T>().Cast<Control>();
        }

        public static IEnumerable<Control> FlattenChildren(this Control control)
        {
            var children = control.Controls.Cast<Control>();
            return children.SelectMany(c => FlattenChildren(c)).Concat(children);
        }
    }
}