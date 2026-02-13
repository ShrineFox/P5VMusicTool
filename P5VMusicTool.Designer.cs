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
            splitContainer1 = new SplitContainer();
            tlp_Collections = new TableLayoutPanel();
            listBox_Songs = new ListBox();
            listBox_Collections = new ListBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox3 = new GroupBox();
            num_SongCueID = new NumericUpDown();
            groupBox_SongDests = new GroupBox();
            checkedListBox_SongDestinations = new CheckedListBox();
            groupBox1 = new GroupBox();
            txt_SongName = new TextBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newProjectToolStripMenuItem = new ToolStripMenuItem();
            loadProjectToolStripMenuItem = new ToolStripMenuItem();
            saveProjectToolStripMenuItem = new ToolStripMenuItem();
            generateBGMToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            addCollectionToolStripMenuItem = new ToolStripMenuItem();
            removeCollectionToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tlp_Collections.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_SongCueID).BeginInit();
            groupBox_SongDests.SuspendLayout();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 28);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tlp_Collections);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Size = new Size(800, 422);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // tlp_Collections
            // 
            tlp_Collections.ColumnCount = 2;
            tlp_Collections.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_Collections.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_Collections.Controls.Add(listBox_Songs, 1, 0);
            tlp_Collections.Controls.Add(listBox_Collections, 0, 0);
            tlp_Collections.Dock = DockStyle.Fill;
            tlp_Collections.Location = new Point(0, 0);
            tlp_Collections.Name = "tlp_Collections";
            tlp_Collections.RowCount = 1;
            tlp_Collections.RowStyles.Add(new RowStyle(SizeType.Percent, 92F));
            tlp_Collections.Size = new Size(266, 422);
            tlp_Collections.TabIndex = 0;
            // 
            // listBox_Songs
            // 
            listBox_Songs.Dock = DockStyle.Fill;
            listBox_Songs.FormattingEnabled = true;
            listBox_Songs.Location = new Point(136, 3);
            listBox_Songs.Name = "listBox_Songs";
            listBox_Songs.Size = new Size(127, 416);
            listBox_Songs.TabIndex = 1;
            listBox_Songs.SelectedIndexChanged += Song_SelectedIndexChanged;
            // 
            // listBox_Collections
            // 
            listBox_Collections.Dock = DockStyle.Fill;
            listBox_Collections.FormattingEnabled = true;
            listBox_Collections.Location = new Point(3, 3);
            listBox_Collections.Name = "listBox_Collections";
            listBox_Collections.Size = new Size(127, 416);
            listBox_Collections.TabIndex = 0;
            listBox_Collections.SelectedIndexChanged += Collection_SelectedIndexChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(groupBox3, 1, 0);
            tableLayoutPanel1.Controls.Add(groupBox_SongDests, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.55704F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 66.442955F));
            tableLayoutPanel1.Size = new Size(530, 422);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(num_SongCueID);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(268, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(259, 135);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Song Cue ID";
            // 
            // num_SongCueID
            // 
            num_SongCueID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            num_SongCueID.Location = new Point(60, 65);
            num_SongCueID.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            num_SongCueID.Name = "num_SongCueID";
            num_SongCueID.Size = new Size(150, 27);
            num_SongCueID.TabIndex = 0;
            // 
            // groupBox_SongDests
            // 
            tableLayoutPanel1.SetColumnSpan(groupBox_SongDests, 2);
            groupBox_SongDests.Controls.Add(checkedListBox_SongDestinations);
            groupBox_SongDests.Dock = DockStyle.Fill;
            groupBox_SongDests.Location = new Point(3, 144);
            groupBox_SongDests.Name = "groupBox_SongDests";
            groupBox_SongDests.Size = new Size(524, 275);
            groupBox_SongDests.TabIndex = 1;
            groupBox_SongDests.TabStop = false;
            groupBox_SongDests.Text = "Destinations";
            // 
            // checkedListBox_SongDestinations
            // 
            checkedListBox_SongDestinations.Dock = DockStyle.Fill;
            checkedListBox_SongDestinations.FormattingEnabled = true;
            checkedListBox_SongDestinations.Location = new Point(3, 23);
            checkedListBox_SongDestinations.Name = "checkedListBox_SongDestinations";
            checkedListBox_SongDestinations.Size = new Size(518, 249);
            checkedListBox_SongDestinations.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_SongName);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(259, 135);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Song Name";
            // 
            // txt_SongName
            // 
            txt_SongName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_SongName.Location = new Point(6, 65);
            txt_SongName.Name = "txt_SongName";
            txt_SongName.ReadOnly = true;
            txt_SongName.Size = new Size(247, 27);
            txt_SongName.TabIndex = 0;
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
            // 
            // saveProjectToolStripMenuItem
            // 
            saveProjectToolStripMenuItem.Name = "saveProjectToolStripMenuItem";
            saveProjectToolStripMenuItem.Size = new Size(188, 26);
            saveProjectToolStripMenuItem.Text = "Save Project";
            // 
            // generateBGMToolStripMenuItem
            // 
            generateBGMToolStripMenuItem.Name = "generateBGMToolStripMenuItem";
            generateBGMToolStripMenuItem.Size = new Size(188, 26);
            generateBGMToolStripMenuItem.Text = "Generate BGM";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addCollectionToolStripMenuItem, removeCollectionToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // addCollectionToolStripMenuItem
            // 
            addCollectionToolStripMenuItem.Name = "addCollectionToolStripMenuItem";
            addCollectionToolStripMenuItem.Size = new Size(217, 26);
            addCollectionToolStripMenuItem.Text = "Add Collection";
            // 
            // removeCollectionToolStripMenuItem
            // 
            removeCollectionToolStripMenuItem.Name = "removeCollectionToolStripMenuItem";
            removeCollectionToolStripMenuItem.Size = new Size(217, 26);
            removeCollectionToolStripMenuItem.Text = "Remove Collection";
            // 
            // P5VMusicTool
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            Name = "P5VMusicTool";
            Text = "Persona 5 Vinesauce BGM Tool";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tlp_Collections.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)num_SongCueID).EndInit();
            groupBox_SongDests.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer splitContainer1;
        private TableLayoutPanel tlp_Collections;
        private ListBox listBox_Songs;
        private ListBox listBox_Collections;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadProjectToolStripMenuItem;
        private ToolStripMenuItem saveProjectToolStripMenuItem;
        private ToolStripMenuItem generateBGMToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem addCollectionToolStripMenuItem;
        private ToolStripMenuItem removeCollectionToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox_SongDests;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private NumericUpDown num_SongCueID;
        private TextBox txt_SongName;
        private CheckedListBox checkedListBox_SongDestinations;
        private ToolStripMenuItem newProjectToolStripMenuItem;
    }
}
