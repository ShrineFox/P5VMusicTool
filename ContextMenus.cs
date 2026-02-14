using System.Drawing.Text;
using System.Security;
using Newtonsoft.Json;

namespace P5VMusicTool
{
    public partial class P5VMusicTool : Form
    {
        private void AddCollection_Click(object sender, EventArgs e)
        {
            AddCollection();
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

        private void AddDestinationToSelectedSong(bool updateUI = true)
        {
            Song selectedSong = (Song)listBox_Songs.SelectedItem;
            Destination selectedDestination = (Destination)listBox_Destinations.SelectedItem;
            if (selectedSong == null || selectedDestination == null) return;
            if (!selectedSong.DestinationIDs.Any(x => x.Equals(selectedDestination.InternalID)))
            {
                selectedSong.DestinationIDs.Add(selectedDestination.InternalID);
                bs_SongDestinations.DataSource = selectedSong.DestinationIDs;
                if (updateUI)
                {
                    bs_SongDestinations.ResetBindings(false); // update UI
                    tabControl_Main.SelectedIndex = 0; // switch to Songs tab
                }
            }
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
            selectedSong.DestinationIDs.RemoveAll(x => x.Equals((int)listBox_SongDestinations.SelectedItem));
            bs_SongDestinations.ResetBindings(false); // update UI
        }

        private void CreateDestination_Click(object sender, EventArgs e)
        {
            CreateDestination();
        }

        private void CreateDestination(bool addToCurrentSong = false)
        {
            int i = 0;
            while (currentProject.Destinations.Any(x => x.InternalID == i))
                i++;

            currentProject.Destinations.Add(new Destination() { Name = "New Destination", InternalID = i });
            if (addToCurrentSong)
            {
                Song selectedSong = (Song)listBox_Songs.SelectedItem;
                if (selectedSong != null)
                {
                    selectedSong.DestinationIDs.Add(currentProject.Destinations.Last().InternalID);
                    bs_SongDestinations.DataSource = selectedSong.DestinationIDs;
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
            foreach(var coll in currentProject.Collections)
            {
                foreach(var song in coll.Songs)
                {
                    song.DestinationIDs.RemoveAll(x => x.Equals(selectedDestination.InternalID));
                }
            }
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

        private void MoveUp_Click(object sender, EventArgs e)
        {
            MoveSelectedItem(-1);
        }

        private void MoveDown_Click(object sender, EventArgs e)
        {
            MoveSelectedItem(1);
        }
    }
}
