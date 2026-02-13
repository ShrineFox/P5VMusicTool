namespace P5VMusicTool
{
    partial class DestinationManager
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
            menuStrip1 = new MenuStrip();
            editToolStripMenuItem = new ToolStripMenuItem();
            addDestinationToolStripMenuItem = new ToolStripMenuItem();
            removeDestinationToolStripMenuItem = new ToolStripMenuItem();
            listBox_Destinations = new ListBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox_D = new GroupBox();
            groupBox_DestLocation = new GroupBox();
            btn_SaveDestChanges = new Button();
            txt_DestName = new TextBox();
            tlp_DestLocation = new TableLayoutPanel();
            txt_DestLocation = new TextBox();
            btn_DestLocation = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox_D.SuspendLayout();
            groupBox_DestLocation.SuspendLayout();
            tlp_DestLocation.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(listBox_Destinations);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Size = new Size(800, 422);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addDestinationToolStripMenuItem, removeDestinationToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // addDestinationToolStripMenuItem
            // 
            addDestinationToolStripMenuItem.Name = "addDestinationToolStripMenuItem";
            addDestinationToolStripMenuItem.Size = new Size(226, 26);
            addDestinationToolStripMenuItem.Text = "Add Destination";
            // 
            // removeDestinationToolStripMenuItem
            // 
            removeDestinationToolStripMenuItem.Name = "removeDestinationToolStripMenuItem";
            removeDestinationToolStripMenuItem.Size = new Size(226, 26);
            removeDestinationToolStripMenuItem.Text = "Remove Destination";
            // 
            // listBox_Destinations
            // 
            listBox_Destinations.Dock = DockStyle.Fill;
            listBox_Destinations.FormattingEnabled = true;
            listBox_Destinations.Location = new Point(0, 0);
            listBox_Destinations.Name = "listBox_Destinations";
            listBox_Destinations.Size = new Size(266, 422);
            listBox_Destinations.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(groupBox_DestLocation, 0, 1);
            tableLayoutPanel1.Controls.Add(btn_SaveDestChanges, 0, 2);
            tableLayoutPanel1.Controls.Add(groupBox_D, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(530, 422);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox_D
            // 
            groupBox_D.Controls.Add(txt_DestName);
            groupBox_D.Dock = DockStyle.Fill;
            groupBox_D.Location = new Point(3, 3);
            groupBox_D.Name = "groupBox_D";
            groupBox_D.Size = new Size(524, 134);
            groupBox_D.TabIndex = 0;
            groupBox_D.TabStop = false;
            groupBox_D.Text = "Destination Name";
            // 
            // groupBox_DestLocation
            // 
            groupBox_DestLocation.Controls.Add(tlp_DestLocation);
            groupBox_DestLocation.Dock = DockStyle.Fill;
            groupBox_DestLocation.Location = new Point(3, 143);
            groupBox_DestLocation.Name = "groupBox_DestLocation";
            groupBox_DestLocation.Size = new Size(524, 134);
            groupBox_DestLocation.TabIndex = 1;
            groupBox_DestLocation.TabStop = false;
            groupBox_DestLocation.Text = "Destination Location";
            // 
            // btn_SaveDestChanges
            // 
            btn_SaveDestChanges.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btn_SaveDestChanges.Location = new Point(265, 283);
            btn_SaveDestChanges.Name = "btn_SaveDestChanges";
            btn_SaveDestChanges.Size = new Size(262, 136);
            btn_SaveDestChanges.TabIndex = 2;
            btn_SaveDestChanges.Text = "Save Changes";
            btn_SaveDestChanges.UseVisualStyleBackColor = true;
            // 
            // txt_DestName
            // 
            txt_DestName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_DestName.Location = new Point(6, 54);
            txt_DestName.Name = "txt_DestName";
            txt_DestName.Size = new Size(509, 27);
            txt_DestName.TabIndex = 1;
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
            tlp_DestLocation.Size = new Size(518, 108);
            tlp_DestLocation.TabIndex = 0;
            // 
            // txt_DestLocation
            // 
            txt_DestLocation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_DestLocation.Location = new Point(3, 3);
            txt_DestLocation.Name = "txt_DestLocation";
            txt_DestLocation.Size = new Size(406, 27);
            txt_DestLocation.TabIndex = 2;
            // 
            // btn_DestLocation
            // 
            btn_DestLocation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btn_DestLocation.Location = new Point(415, 3);
            btn_DestLocation.Name = "btn_DestLocation";
            btn_DestLocation.Size = new Size(100, 102);
            btn_DestLocation.TabIndex = 3;
            btn_DestLocation.Text = "...";
            btn_DestLocation.UseVisualStyleBackColor = true;
            // 
            // DestinationManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            Name = "DestinationManager";
            Text = "P5V BGM Tool - Manage Destinations";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            groupBox_D.ResumeLayout(false);
            groupBox_D.PerformLayout();
            groupBox_DestLocation.ResumeLayout(false);
            tlp_DestLocation.ResumeLayout(false);
            tlp_DestLocation.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer splitContainer1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem addDestinationToolStripMenuItem;
        private ToolStripMenuItem removeDestinationToolStripMenuItem;
        private ListBox listBox_Destinations;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox_DestLocation;
        private GroupBox groupBox_D;
        private Button btn_SaveDestChanges;
        private TableLayoutPanel tlp_DestLocation;
        private Button btn_DestLocation;
        private TextBox txt_DestLocation;
        private TextBox txt_DestName;
    }
}
