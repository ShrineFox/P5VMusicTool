namespace P5VMusicTool
{
    partial class P5VMusicTool
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newProjectToolStripMenuItem = new ToolStripMenuItem();
            loadProjectToolStripMenuItem = new ToolStripMenuItem();
            saveProjectToolStripMenuItem = new ToolStripMenuItem();
            generateBGMToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            addCollectionToolStripMenuItem = new ToolStripMenuItem();
            removeCollectionToolStripMenuItem = new ToolStripMenuItem();
            addSongToolStripMenuItem = new ToolStripMenuItem();
            removeSongToolStripMenuItem = new ToolStripMenuItem();
            addDestinationToolStripMenuItem = new ToolStripMenuItem();
            removeDestinationToolStripMenuItem = new ToolStripMenuItem();
            addDestToCurrentSongToolStripMenuItem = new ToolStripMenuItem();
            removeDestFromCurrentSongToolStripMenuItem = new ToolStripMenuItem();
            tabControl_Main = new TabControl();
            tabPage_Songs = new TabPage();
            splitContainer1 = new SplitContainer();
            tlp_Collections = new TableLayoutPanel();
            listBox_Songs = new ListBox();
            contextMenuStrip = new ContextMenuStrip(components);
            addToolStripMenuItem = new ToolStripMenuItem();
            removeToolStripMenuItem = new ToolStripMenuItem();
            addDestinationToSelectedSongToolStripMenuItem = new ToolStripMenuItem();
            listBox_Collections = new ListBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox_SongLocation = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            btn_SongLocation = new Button();
            txt_SongLocation = new TextBox();
            groupBox3 = new GroupBox();
            num_SongCueID = new NumericUpDown();
            groupBox_SongDests = new GroupBox();
            listBox_SongDestinations = new ListBox();
            groupBox1 = new GroupBox();
            txt_SongName = new TextBox();
            tabPage_Destinations = new TabPage();
            splitContainer2 = new SplitContainer();
            listBox_Destinations = new ListBox();
            tableLayoutPanel_Dest = new TableLayoutPanel();
            groupBox4 = new GroupBox();
            tlp_BattleBGM = new TableLayoutPanel();
            chk_DestVictory = new CheckBox();
            chk_DestTalk = new CheckBox();
            chk_DestPinch = new CheckBox();
            chk_DestAmbush = new CheckBox();
            chk_DestNormal = new CheckBox();
            groupBox2 = new GroupBox();
            txt_DestCostumeName = new TextBox();
            groupBox_DestLocation = new GroupBox();
            tlp_DestLocation = new TableLayoutPanel();
            btn_DestLocation = new Button();
            txt_DestLocation = new TextBox();
            groupBox_D = new GroupBox();
            txt_DestName = new TextBox();
            menuStrip1.SuspendLayout();
            tabControl_Main.SuspendLayout();
            tabPage_Songs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tlp_Collections.SuspendLayout();
            contextMenuStrip.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox_SongLocation.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_SongCueID).BeginInit();
            groupBox_SongDests.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage_Destinations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            tableLayoutPanel_Dest.SuspendLayout();
            groupBox4.SuspendLayout();
            tlp_BattleBGM.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox_DestLocation.SuspendLayout();
            tlp_DestLocation.SuspendLayout();
            groupBox_D.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newProjectToolStripMenuItem, loadProjectToolStripMenuItem, saveProjectToolStripMenuItem, generateBGMToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // newProjectToolStripMenuItem
            // 
            newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            newProjectToolStripMenuItem.Size = new Size(188, 26);
            newProjectToolStripMenuItem.Text = "New Project";
            newProjectToolStripMenuItem.Click += NewProject_Click;
            // 
            // loadProjectToolStripMenuItem
            // 
            loadProjectToolStripMenuItem.Name = "loadProjectToolStripMenuItem";
            loadProjectToolStripMenuItem.Size = new Size(188, 26);
            loadProjectToolStripMenuItem.Text = "Load Project";
            loadProjectToolStripMenuItem.Click += LoadProject_Click;
            // 
            // saveProjectToolStripMenuItem
            // 
            saveProjectToolStripMenuItem.Name = "saveProjectToolStripMenuItem";
            saveProjectToolStripMenuItem.Size = new Size(188, 26);
            saveProjectToolStripMenuItem.Text = "Save Project";
            saveProjectToolStripMenuItem.Click += SaveProject_Click;
            // 
            // generateBGMToolStripMenuItem
            // 
            generateBGMToolStripMenuItem.Name = "generateBGMToolStripMenuItem";
            generateBGMToolStripMenuItem.Size = new Size(188, 26);
            generateBGMToolStripMenuItem.Text = "Generate BGM";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addCollectionToolStripMenuItem, removeCollectionToolStripMenuItem, addSongToolStripMenuItem, removeSongToolStripMenuItem, addDestinationToolStripMenuItem, removeDestinationToolStripMenuItem, addDestToCurrentSongToolStripMenuItem, removeDestFromCurrentSongToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // addCollectionToolStripMenuItem
            // 
            addCollectionToolStripMenuItem.Name = "addCollectionToolStripMenuItem";
            addCollectionToolStripMenuItem.Size = new Size(306, 26);
            addCollectionToolStripMenuItem.Text = "Add Collection";
            addCollectionToolStripMenuItem.Click += AddCollection_Click;
            // 
            // removeCollectionToolStripMenuItem
            // 
            removeCollectionToolStripMenuItem.Name = "removeCollectionToolStripMenuItem";
            removeCollectionToolStripMenuItem.Size = new Size(306, 26);
            removeCollectionToolStripMenuItem.Text = "Remove Collection";
            removeCollectionToolStripMenuItem.Click += RemoveCollection_Click;
            // 
            // addSongToolStripMenuItem
            // 
            addSongToolStripMenuItem.Name = "addSongToolStripMenuItem";
            addSongToolStripMenuItem.Size = new Size(306, 26);
            addSongToolStripMenuItem.Text = "Add Song";
            addSongToolStripMenuItem.Click += AddSong_Click;
            // 
            // removeSongToolStripMenuItem
            // 
            removeSongToolStripMenuItem.Name = "removeSongToolStripMenuItem";
            removeSongToolStripMenuItem.Size = new Size(306, 26);
            removeSongToolStripMenuItem.Text = "Remove Song";
            removeSongToolStripMenuItem.Click += RemoveSong_Click;
            // 
            // addDestinationToolStripMenuItem
            // 
            addDestinationToolStripMenuItem.Name = "addDestinationToolStripMenuItem";
            addDestinationToolStripMenuItem.Size = new Size(306, 26);
            addDestinationToolStripMenuItem.Text = "Create Destination";
            addDestinationToolStripMenuItem.Click += CreateDestination_Click;
            // 
            // removeDestinationToolStripMenuItem
            // 
            removeDestinationToolStripMenuItem.Name = "removeDestinationToolStripMenuItem";
            removeDestinationToolStripMenuItem.Size = new Size(306, 26);
            removeDestinationToolStripMenuItem.Text = "Delete Destination";
            removeDestinationToolStripMenuItem.Click += DeleteDestination_Click;
            // 
            // addDestToCurrentSongToolStripMenuItem
            // 
            addDestToCurrentSongToolStripMenuItem.Name = "addDestToCurrentSongToolStripMenuItem";
            addDestToCurrentSongToolStripMenuItem.Size = new Size(306, 26);
            addDestToCurrentSongToolStripMenuItem.Text = "Add Dest to Current Song";
            addDestToCurrentSongToolStripMenuItem.Click += AddDestToCurrentSong_Click;
            // 
            // removeDestFromCurrentSongToolStripMenuItem
            // 
            removeDestFromCurrentSongToolStripMenuItem.Name = "removeDestFromCurrentSongToolStripMenuItem";
            removeDestFromCurrentSongToolStripMenuItem.Size = new Size(306, 26);
            removeDestFromCurrentSongToolStripMenuItem.Text = "Remove Dest from Current Song";
            removeDestFromCurrentSongToolStripMenuItem.Click += RemoveDestFromCurrentSong_Click;
            // 
            // tabControl_Main
            // 
            tabControl_Main.Controls.Add(tabPage_Songs);
            tabControl_Main.Controls.Add(tabPage_Destinations);
            tabControl_Main.Dock = DockStyle.Fill;
            tabControl_Main.Location = new Point(0, 28);
            tabControl_Main.Name = "tabControl_Main";
            tabControl_Main.SelectedIndex = 0;
            tabControl_Main.Size = new Size(800, 422);
            tabControl_Main.TabIndex = 2;
            // 
            // tabPage_Songs
            // 
            tabPage_Songs.Controls.Add(splitContainer1);
            tabPage_Songs.Location = new Point(4, 29);
            tabPage_Songs.Name = "tabPage_Songs";
            tabPage_Songs.Padding = new Padding(3);
            tabPage_Songs.Size = new Size(792, 389);
            tabPage_Songs.TabIndex = 0;
            tabPage_Songs.Text = "Songs";
            tabPage_Songs.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tlp_Collections);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Size = new Size(786, 383);
            splitContainer1.SplitterDistance = 262;
            splitContainer1.TabIndex = 1;
            // 
            // tlp_Collections
            // 
            tlp_Collections.ColumnCount = 2;
            tlp_Collections.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.4661636F));
            tlp_Collections.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.5338364F));
            tlp_Collections.Controls.Add(listBox_Songs, 1, 0);
            tlp_Collections.Controls.Add(listBox_Collections, 0, 0);
            tlp_Collections.Dock = DockStyle.Fill;
            tlp_Collections.Location = new Point(0, 0);
            tlp_Collections.Name = "tlp_Collections";
            tlp_Collections.RowCount = 1;
            tlp_Collections.RowStyles.Add(new RowStyle(SizeType.Percent, 92F));
            tlp_Collections.Size = new Size(262, 383);
            tlp_Collections.TabIndex = 0;
            // 
            // listBox_Songs
            // 
            listBox_Songs.ContextMenuStrip = contextMenuStrip;
            listBox_Songs.Dock = DockStyle.Fill;
            listBox_Songs.FormattingEnabled = true;
            listBox_Songs.Location = new Point(98, 3);
            listBox_Songs.Name = "listBox_Songs";
            listBox_Songs.Size = new Size(161, 377);
            listBox_Songs.TabIndex = 1;
            listBox_Songs.SelectedIndexChanged += Song_SelectedIndexChanged;
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.ImageScalingSize = new Size(20, 20);
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { addToolStripMenuItem, removeToolStripMenuItem, addDestinationToSelectedSongToolStripMenuItem });
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new Size(304, 76);
            contextMenuStrip.Opening += ContextMenu_Opening;
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(303, 24);
            addToolStripMenuItem.Text = "Add";
            addToolStripMenuItem.Click += Add_Click;
            // 
            // removeToolStripMenuItem
            // 
            removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            removeToolStripMenuItem.Size = new Size(303, 24);
            removeToolStripMenuItem.Text = "Remove";
            removeToolStripMenuItem.Click += Remove_Click;
            // 
            // addDestinationToSelectedSongToolStripMenuItem
            // 
            addDestinationToSelectedSongToolStripMenuItem.Name = "addDestinationToSelectedSongToolStripMenuItem";
            addDestinationToSelectedSongToolStripMenuItem.Size = new Size(303, 24);
            addDestinationToSelectedSongToolStripMenuItem.Text = "Add Destination to Selected Song";
            addDestinationToSelectedSongToolStripMenuItem.Click += AddDestinationToSelectedSong_Click;
            // 
            // listBox_Collections
            // 
            listBox_Collections.ContextMenuStrip = contextMenuStrip;
            listBox_Collections.Dock = DockStyle.Fill;
            listBox_Collections.FormattingEnabled = true;
            listBox_Collections.Location = new Point(3, 3);
            listBox_Collections.Name = "listBox_Collections";
            listBox_Collections.Size = new Size(89, 377);
            listBox_Collections.TabIndex = 0;
            listBox_Collections.SelectedIndexChanged += Collection_SelectedIndexChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(groupBox_SongLocation, 0, 2);
            tableLayoutPanel1.Controls.Add(groupBox3, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox_SongDests, 1, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(520, 383);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox_SongLocation
            // 
            tableLayoutPanel1.SetColumnSpan(groupBox_SongLocation, 2);
            groupBox_SongLocation.Controls.Add(tableLayoutPanel2);
            groupBox_SongLocation.Dock = DockStyle.Fill;
            groupBox_SongLocation.Location = new Point(3, 257);
            groupBox_SongLocation.Name = "groupBox_SongLocation";
            groupBox_SongLocation.Size = new Size(514, 123);
            groupBox_SongLocation.TabIndex = 3;
            groupBox_SongLocation.TabStop = false;
            groupBox_SongLocation.Text = "Song Location";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.56778F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.43222F));
            tableLayoutPanel2.Controls.Add(btn_SongLocation, 1, 0);
            tableLayoutPanel2.Controls.Add(txt_SongLocation, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 23);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(508, 97);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btn_SongLocation
            // 
            btn_SongLocation.Dock = DockStyle.Fill;
            btn_SongLocation.Location = new Point(407, 3);
            btn_SongLocation.Name = "btn_SongLocation";
            btn_SongLocation.Size = new Size(98, 91);
            btn_SongLocation.TabIndex = 3;
            btn_SongLocation.Text = "...";
            btn_SongLocation.UseVisualStyleBackColor = true;
            // 
            // txt_SongLocation
            // 
            txt_SongLocation.Dock = DockStyle.Fill;
            txt_SongLocation.Location = new Point(3, 3);
            txt_SongLocation.Name = "txt_SongLocation";
            txt_SongLocation.Size = new Size(398, 27);
            txt_SongLocation.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(num_SongCueID);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(3, 130);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(254, 121);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Song Cue ID";
            // 
            // num_SongCueID
            // 
            num_SongCueID.Dock = DockStyle.Fill;
            num_SongCueID.Location = new Point(3, 23);
            num_SongCueID.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            num_SongCueID.Name = "num_SongCueID";
            num_SongCueID.Size = new Size(248, 27);
            num_SongCueID.TabIndex = 0;
            // 
            // groupBox_SongDests
            // 
            groupBox_SongDests.Controls.Add(listBox_SongDestinations);
            groupBox_SongDests.Dock = DockStyle.Fill;
            groupBox_SongDests.Location = new Point(263, 3);
            groupBox_SongDests.Name = "groupBox_SongDests";
            tableLayoutPanel1.SetRowSpan(groupBox_SongDests, 2);
            groupBox_SongDests.Size = new Size(254, 248);
            groupBox_SongDests.TabIndex = 1;
            groupBox_SongDests.TabStop = false;
            groupBox_SongDests.Text = "Destinations";
            // 
            // listBox_SongDestinations
            // 
            listBox_SongDestinations.ContextMenuStrip = contextMenuStrip;
            listBox_SongDestinations.Dock = DockStyle.Fill;
            listBox_SongDestinations.FormattingEnabled = true;
            listBox_SongDestinations.Location = new Point(3, 23);
            listBox_SongDestinations.Name = "listBox_SongDestinations";
            listBox_SongDestinations.Size = new Size(248, 222);
            listBox_SongDestinations.TabIndex = 2;
            listBox_SongDestinations.DoubleClick += SongDestinations_DoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_SongName);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(254, 121);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Song Name";
            // 
            // txt_SongName
            // 
            txt_SongName.Dock = DockStyle.Fill;
            txt_SongName.Location = new Point(3, 23);
            txt_SongName.Name = "txt_SongName";
            txt_SongName.Size = new Size(248, 27);
            txt_SongName.TabIndex = 0;
            // 
            // tabPage_Destinations
            // 
            tabPage_Destinations.Controls.Add(splitContainer2);
            tabPage_Destinations.Location = new Point(4, 29);
            tabPage_Destinations.Name = "tabPage_Destinations";
            tabPage_Destinations.Padding = new Padding(3);
            tabPage_Destinations.Size = new Size(792, 389);
            tabPage_Destinations.TabIndex = 1;
            tabPage_Destinations.Text = "Destinations";
            tabPage_Destinations.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(3, 3);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(listBox_Destinations);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(tableLayoutPanel_Dest);
            splitContainer2.Size = new Size(786, 383);
            splitContainer2.SplitterDistance = 262;
            splitContainer2.TabIndex = 1;
            // 
            // listBox_Destinations
            // 
            listBox_Destinations.ContextMenuStrip = contextMenuStrip;
            listBox_Destinations.Dock = DockStyle.Fill;
            listBox_Destinations.FormattingEnabled = true;
            listBox_Destinations.Location = new Point(0, 0);
            listBox_Destinations.Name = "listBox_Destinations";
            listBox_Destinations.Size = new Size(262, 383);
            listBox_Destinations.TabIndex = 1;
            listBox_Destinations.SelectedIndexChanged += Destinations_SelectedIndexChanged;
            // 
            // tableLayoutPanel_Dest
            // 
            tableLayoutPanel_Dest.ColumnCount = 2;
            tableLayoutPanel_Dest.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel_Dest.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel_Dest.Controls.Add(groupBox4, 1, 1);
            tableLayoutPanel_Dest.Controls.Add(groupBox2, 1, 0);
            tableLayoutPanel_Dest.Controls.Add(groupBox_DestLocation, 0, 1);
            tableLayoutPanel_Dest.Controls.Add(groupBox_D, 0, 0);
            tableLayoutPanel_Dest.Dock = DockStyle.Fill;
            tableLayoutPanel_Dest.Location = new Point(0, 0);
            tableLayoutPanel_Dest.Name = "tableLayoutPanel_Dest";
            tableLayoutPanel_Dest.RowCount = 3;
            tableLayoutPanel_Dest.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel_Dest.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel_Dest.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel_Dest.Size = new Size(520, 383);
            tableLayoutPanel_Dest.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tlp_BattleBGM);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(263, 130);
            groupBox4.Name = "groupBox4";
            tableLayoutPanel_Dest.SetRowSpan(groupBox4, 2);
            groupBox4.Size = new Size(254, 250);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Costume BGM";
            // 
            // tlp_BattleBGM
            // 
            tlp_BattleBGM.ColumnCount = 1;
            tlp_BattleBGM.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp_BattleBGM.Controls.Add(chk_DestVictory, 0, 4);
            tlp_BattleBGM.Controls.Add(chk_DestTalk, 0, 3);
            tlp_BattleBGM.Controls.Add(chk_DestPinch, 0, 2);
            tlp_BattleBGM.Controls.Add(chk_DestAmbush, 1, 0);
            tlp_BattleBGM.Controls.Add(chk_DestNormal, 0, 0);
            tlp_BattleBGM.Dock = DockStyle.Fill;
            tlp_BattleBGM.Location = new Point(3, 23);
            tlp_BattleBGM.Name = "tlp_BattleBGM";
            tlp_BattleBGM.RowCount = 5;
            tlp_BattleBGM.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlp_BattleBGM.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlp_BattleBGM.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlp_BattleBGM.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlp_BattleBGM.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlp_BattleBGM.Size = new Size(248, 224);
            tlp_BattleBGM.TabIndex = 0;
            // 
            // chk_DestVictory
            // 
            chk_DestVictory.AutoSize = true;
            chk_DestVictory.Location = new Point(3, 179);
            chk_DestVictory.Name = "chk_DestVictory";
            chk_DestVictory.Size = new Size(120, 24);
            chk_DestVictory.TabIndex = 4;
            chk_DestVictory.Text = "Battle Results";
            chk_DestVictory.UseVisualStyleBackColor = true;
            // 
            // chk_DestTalk
            // 
            chk_DestTalk.AutoSize = true;
            chk_DestTalk.Location = new Point(3, 135);
            chk_DestTalk.Name = "chk_DestTalk";
            chk_DestTalk.Size = new Size(154, 24);
            chk_DestTalk.TabIndex = 3;
            chk_DestTalk.Text = "Battle Negotiation";
            chk_DestTalk.UseVisualStyleBackColor = true;
            // 
            // chk_DestPinch
            // 
            chk_DestPinch.AutoSize = true;
            chk_DestPinch.Location = new Point(3, 91);
            chk_DestPinch.Name = "chk_DestPinch";
            chk_DestPinch.Size = new Size(194, 24);
            chk_DestPinch.TabIndex = 2;
            chk_DestPinch.Text = "Enemy Advantage Battle";
            chk_DestPinch.UseVisualStyleBackColor = true;
            // 
            // chk_DestAmbush
            // 
            chk_DestAmbush.AutoSize = true;
            chk_DestAmbush.Location = new Point(3, 47);
            chk_DestAmbush.Name = "chk_DestAmbush";
            chk_DestAmbush.Size = new Size(190, 24);
            chk_DestAmbush.TabIndex = 1;
            chk_DestAmbush.Text = "Player Advantage Battle";
            chk_DestAmbush.UseVisualStyleBackColor = true;
            // 
            // chk_DestNormal
            // 
            chk_DestNormal.AutoSize = true;
            chk_DestNormal.Location = new Point(3, 3);
            chk_DestNormal.Name = "chk_DestNormal";
            chk_DestNormal.Size = new Size(124, 24);
            chk_DestNormal.TabIndex = 0;
            chk_DestNormal.Text = "Normal Battle";
            chk_DestNormal.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txt_DestCostumeName);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(263, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(254, 121);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Costume Name";
            // 
            // txt_DestCostumeName
            // 
            txt_DestCostumeName.Dock = DockStyle.Fill;
            txt_DestCostumeName.Location = new Point(3, 23);
            txt_DestCostumeName.Name = "txt_DestCostumeName";
            txt_DestCostumeName.Size = new Size(248, 27);
            txt_DestCostumeName.TabIndex = 1;
            // 
            // groupBox_DestLocation
            // 
            groupBox_DestLocation.Controls.Add(tlp_DestLocation);
            groupBox_DestLocation.Dock = DockStyle.Fill;
            groupBox_DestLocation.Location = new Point(3, 130);
            groupBox_DestLocation.Name = "groupBox_DestLocation";
            groupBox_DestLocation.Size = new Size(254, 121);
            groupBox_DestLocation.TabIndex = 1;
            groupBox_DestLocation.TabStop = false;
            groupBox_DestLocation.Text = "Destination Location";
            // 
            // tlp_DestLocation
            // 
            tlp_DestLocation.ColumnCount = 2;
            tlp_DestLocation.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.56778F));
            tlp_DestLocation.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.43222F));
            tlp_DestLocation.Controls.Add(btn_DestLocation, 1, 0);
            tlp_DestLocation.Controls.Add(txt_DestLocation, 0, 0);
            tlp_DestLocation.Dock = DockStyle.Fill;
            tlp_DestLocation.Location = new Point(3, 23);
            tlp_DestLocation.Name = "tlp_DestLocation";
            tlp_DestLocation.RowCount = 1;
            tlp_DestLocation.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_DestLocation.Size = new Size(248, 95);
            tlp_DestLocation.TabIndex = 0;
            // 
            // btn_DestLocation
            // 
            btn_DestLocation.Dock = DockStyle.Fill;
            btn_DestLocation.Location = new Point(200, 3);
            btn_DestLocation.Name = "btn_DestLocation";
            btn_DestLocation.Size = new Size(45, 89);
            btn_DestLocation.TabIndex = 3;
            btn_DestLocation.Text = "...";
            btn_DestLocation.UseVisualStyleBackColor = true;
            // 
            // txt_DestLocation
            // 
            txt_DestLocation.Dock = DockStyle.Fill;
            txt_DestLocation.Location = new Point(3, 3);
            txt_DestLocation.Name = "txt_DestLocation";
            txt_DestLocation.Size = new Size(191, 27);
            txt_DestLocation.TabIndex = 2;
            // 
            // groupBox_D
            // 
            groupBox_D.Controls.Add(txt_DestName);
            groupBox_D.Dock = DockStyle.Fill;
            groupBox_D.Location = new Point(3, 3);
            groupBox_D.Name = "groupBox_D";
            groupBox_D.Size = new Size(254, 121);
            groupBox_D.TabIndex = 0;
            groupBox_D.TabStop = false;
            groupBox_D.Text = "Destination Name";
            // 
            // txt_DestName
            // 
            txt_DestName.Dock = DockStyle.Fill;
            txt_DestName.Location = new Point(3, 23);
            txt_DestName.Name = "txt_DestName";
            txt_DestName.Size = new Size(248, 27);
            txt_DestName.TabIndex = 1;
            // 
            // P5VMusicTool
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl_Main);
            Controls.Add(menuStrip1);
            Name = "P5VMusicTool";
            Text = "Persona 5 Vinesauce BGM Tool";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl_Main.ResumeLayout(false);
            tabPage_Songs.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tlp_Collections.ResumeLayout(false);
            contextMenuStrip.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox_SongLocation.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)num_SongCueID).EndInit();
            groupBox_SongDests.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage_Destinations.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            tableLayoutPanel_Dest.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            tlp_BattleBGM.ResumeLayout(false);
            tlp_BattleBGM.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox_DestLocation.ResumeLayout(false);
            tlp_DestLocation.ResumeLayout(false);
            tlp_DestLocation.PerformLayout();
            groupBox_D.ResumeLayout(false);
            groupBox_D.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadProjectToolStripMenuItem;
        private ToolStripMenuItem saveProjectToolStripMenuItem;
        private ToolStripMenuItem generateBGMToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem addCollectionToolStripMenuItem;
        private ToolStripMenuItem removeCollectionToolStripMenuItem;
        private ToolStripMenuItem newProjectToolStripMenuItem;
        private TabControl tabControl_Main;
        private TabPage tabPage_Songs;
        private SplitContainer splitContainer1;
        private TableLayoutPanel tlp_Collections;
        private ListBox listBox_Songs;
        private ListBox listBox_Collections;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox3;
        private NumericUpDown num_SongCueID;
        private GroupBox groupBox_SongDests;
        private GroupBox groupBox1;
        private TextBox txt_SongName;
        private TabPage tabPage_Destinations;
        private SplitContainer splitContainer2;
        private ListBox listBox_Destinations;
        private TableLayoutPanel tableLayoutPanel_Dest;
        private GroupBox groupBox_DestLocation;
        private TableLayoutPanel tlp_DestLocation;
        private Button btn_DestLocation;
        private TextBox txt_DestLocation;
        private GroupBox groupBox_D;
        private TextBox txt_DestName;
        private GroupBox groupBox2;
        private TextBox txt_DestCostumeName;
        private GroupBox groupBox4;
        private TableLayoutPanel tlp_BattleBGM;
        private CheckBox chk_DestAmbush;
        private CheckBox chk_DestNormal;
        private CheckBox chk_DestVictory;
        private CheckBox chk_DestTalk;
        private CheckBox chk_DestPinch;
        private ListBox listBox_SongDestinations;
        private ToolStripMenuItem addDestinationToolStripMenuItem;
        private ToolStripMenuItem removeDestinationToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem removeToolStripMenuItem;
        private GroupBox groupBox_SongLocation;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btn_SongLocation;
        private TextBox txt_SongLocation;
        private ToolStripMenuItem addSongToolStripMenuItem;
        private ToolStripMenuItem removeSongToolStripMenuItem;
        private ToolStripMenuItem addDestToCurrentSongToolStripMenuItem;
        private ToolStripMenuItem removeDestFromCurrentSongToolStripMenuItem;
        private ToolStripMenuItem addDestinationToSelectedSongToolStripMenuItem;
    }
}
