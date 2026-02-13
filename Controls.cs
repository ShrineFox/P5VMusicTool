using System.Drawing.Text;
using System.Security;
using Newtonsoft.Json;

namespace P5VMusicTool
{
    public partial class P5VMusicTool : Form
    {
        private void SetSongName()
        {
            Song selectedSong = (Song)listBox_Songs.SelectedItem;
            if (selectedSong == null)
                return;

            txt_SongName.DataBindings.Clear();
            txt_SongName.DataBindings.Add("Text", selectedSong, "Name", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void SetDestCueID()
        {
            Destination selectedDest = (Destination)listBox_Destinations.SelectedItem;
            if (selectedDest == null)
                return;

            num_CueID.DataBindings.Clear();
            num_CueID.DataBindings.Add("Value", selectedDest, "CueID", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void SetDestWaveID()
        {
            Destination selectedDest = (Destination)listBox_Destinations.SelectedItem;
            if (selectedDest == null)
                return;

            num_WaveID.DataBindings.Clear();
            num_WaveID.DataBindings.Add("Value", selectedDest, "WaveID", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void SetSongPath()
        {
            Song selectedSong = (Song)listBox_Songs.SelectedItem;
            if (selectedSong == null)
                return;

            txt_SongPath.DataBindings.Clear();
            txt_SongPath.DataBindings.Add("Text", selectedSong, "Path", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void SetDestinationName()
        {
            Destination selectedDest = (Destination)listBox_Destinations.SelectedItem;
            if (selectedDest == null)
                return;

            txt_DestName.DataBindings.Clear();
            txt_DestName.DataBindings.Add("Text", selectedDest, "Name", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void SetDestinationCostumeName()
        {
            Destination selectedDest = (Destination)listBox_Destinations.SelectedItem;
            if (selectedDest == null)
                return;

            txt_DestCostumeName.DataBindings.Clear();
            txt_DestCostumeName.DataBindings.Add("Text", selectedDest, "CostumeName", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void SetDestChk_NormalBattle()
        {
            Destination selectedDest = (Destination)listBox_Destinations.SelectedItem;
            if (selectedDest == null)
                return;

            chk_DestNormal.DataBindings.Clear();
            chk_DestNormal.DataBindings.Add("Checked", selectedDest, "NormalBattle", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void SetDestChk_AmbushBattle()
        {
            Destination selectedDest = (Destination)listBox_Destinations.SelectedItem;
            if (selectedDest == null)
                return;

            chk_DestAmbush.DataBindings.Clear();
            chk_DestAmbush.DataBindings.Add("Checked", selectedDest, "AmbushBattle", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void SetDestChk_PinchBattle()
        {
            Destination selectedDest = (Destination)listBox_Destinations.SelectedItem;
            if (selectedDest == null)
                return;

            chk_DestPinch.DataBindings.Clear();
            chk_DestPinch.DataBindings.Add("Checked", selectedDest, "PinchBattle", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void SetDestChk_BattleTalk()
        {
            Destination selectedDest = (Destination)listBox_Destinations.SelectedItem;
            if (selectedDest == null)
                return;

            chk_DestTalk.DataBindings.Clear();
            chk_DestTalk.DataBindings.Add("Checked", selectedDest, "BattleTalk", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void SetDestChk_BattleVictory()
        {
            Destination selectedDest = (Destination)listBox_Destinations.SelectedItem;
            if (selectedDest == null)
                return;

            chk_DestVictory.DataBindings.Clear();
            chk_DestVictory.DataBindings.Add("Checked", selectedDest, "BattleVictory", false, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}
