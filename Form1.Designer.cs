
namespace SteamFolderUpdater
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.to_TextBox = new System.Windows.Forms.TextBox();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.from_TextBox = new System.Windows.Forms.TextBox();
            this.btn_BrowseFrom = new System.Windows.Forms.Button();
            this.btn_BrowseTo = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pathSelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.watcherCheckBox = new System.Windows.Forms.CheckBox();
            this.consoleEnable = new System.Windows.Forms.CheckBox();
            this.btn_Transfer = new System.Windows.Forms.Button();
            this.steamPathLabel = new System.Windows.Forms.Label();
            this.steam_TextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.steam_GB = new System.Windows.Forms.GroupBox();
            this.closeSteam_CheckBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pathSelectionGroupBox.SuspendLayout();
            this.steam_GB.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // to_TextBox
            // 
            this.to_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.to_TextBox.Location = new System.Drawing.Point(63, 48);
            this.to_TextBox.Name = "to_TextBox";
            this.to_TextBox.Size = new System.Drawing.Size(207, 23);
            this.to_TextBox.TabIndex = 0;
            this.to_TextBox.TextChanged += new System.EventHandler(this.to_TextBox_TextChanged);
            this.to_TextBox.MouseHover += new System.EventHandler(this.to_TextBox_MouseHover);
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(13, 26);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(44, 15);
            this.fromLabel.TabIndex = 1;
            this.fromLabel.Text = "From : ";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(13, 55);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(25, 15);
            this.toLabel.TabIndex = 2;
            this.toLabel.Text = "To :";
            // 
            // from_TextBox
            // 
            this.from_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.from_TextBox.Location = new System.Drawing.Point(63, 22);
            this.from_TextBox.Name = "from_TextBox";
            this.from_TextBox.Size = new System.Drawing.Size(207, 23);
            this.from_TextBox.TabIndex = 3;
            this.from_TextBox.TextChanged += new System.EventHandler(this.from_TextBox_TextChanged);
            this.from_TextBox.MouseHover += new System.EventHandler(this.from_TextBox_MouseHover);
            // 
            // btn_BrowseFrom
            // 
            this.btn_BrowseFrom.Location = new System.Drawing.Point(293, 22);
            this.btn_BrowseFrom.Name = "btn_BrowseFrom";
            this.btn_BrowseFrom.Size = new System.Drawing.Size(75, 23);
            this.btn_BrowseFrom.TabIndex = 4;
            this.btn_BrowseFrom.Text = "Browse";
            this.btn_BrowseFrom.UseVisualStyleBackColor = true;
            this.btn_BrowseFrom.Click += new System.EventHandler(this.btn_BrowseFrom_Click);
            // 
            // btn_BrowseTo
            // 
            this.btn_BrowseTo.Location = new System.Drawing.Point(293, 51);
            this.btn_BrowseTo.Name = "btn_BrowseTo";
            this.btn_BrowseTo.Size = new System.Drawing.Size(75, 23);
            this.btn_BrowseTo.TabIndex = 5;
            this.btn_BrowseTo.Text = "Browse";
            this.btn_BrowseTo.UseVisualStyleBackColor = true;
            this.btn_BrowseTo.Click += new System.EventHandler(this.btn_BrowseTo_Click);
            // 
            // pathSelectionGroupBox
            // 
            this.pathSelectionGroupBox.Controls.Add(this.from_TextBox);
            this.pathSelectionGroupBox.Controls.Add(this.btn_BrowseTo);
            this.pathSelectionGroupBox.Controls.Add(this.to_TextBox);
            this.pathSelectionGroupBox.Controls.Add(this.btn_BrowseFrom);
            this.pathSelectionGroupBox.Controls.Add(this.fromLabel);
            this.pathSelectionGroupBox.Controls.Add(this.toLabel);
            this.pathSelectionGroupBox.Location = new System.Drawing.Point(17, 274);
            this.pathSelectionGroupBox.Name = "pathSelectionGroupBox";
            this.pathSelectionGroupBox.Size = new System.Drawing.Size(379, 92);
            this.pathSelectionGroupBox.TabIndex = 6;
            this.pathSelectionGroupBox.TabStop = false;
            this.pathSelectionGroupBox.Text = "Path Selection";
            // 
            // watcherCheckBox
            // 
            this.watcherCheckBox.AutoSize = true;
            this.watcherCheckBox.Location = new System.Drawing.Point(36, 34);
            this.watcherCheckBox.Name = "watcherCheckBox";
            this.watcherCheckBox.Size = new System.Drawing.Size(108, 19);
            this.watcherCheckBox.TabIndex = 7;
            this.watcherCheckBox.Text = "Enable Watcher";
            this.watcherCheckBox.UseVisualStyleBackColor = true;
            this.watcherCheckBox.CheckedChanged += new System.EventHandler(this.watcherCheckBox_CheckedChanged);
            this.watcherCheckBox.MouseHover += new System.EventHandler(this.watcherCheckBox_MouseHover);
            // 
            // consoleEnable
            // 
            this.consoleEnable.AutoSize = true;
            this.consoleEnable.Location = new System.Drawing.Point(36, 59);
            this.consoleEnable.Name = "consoleEnable";
            this.consoleEnable.Size = new System.Drawing.Size(147, 19);
            this.consoleEnable.TabIndex = 8;
            this.consoleEnable.Text = "Enable Console Logger";
            this.consoleEnable.UseVisualStyleBackColor = true;
            this.consoleEnable.CheckedChanged += new System.EventHandler(this.consoleEnable_CheckedChanged);
            this.consoleEnable.MouseHover += new System.EventHandler(this.consoleEnable_MouseHover);
            // 
            // btn_Transfer
            // 
            this.btn_Transfer.Location = new System.Drawing.Point(17, 372);
            this.btn_Transfer.Name = "btn_Transfer";
            this.btn_Transfer.Size = new System.Drawing.Size(379, 38);
            this.btn_Transfer.TabIndex = 9;
            this.btn_Transfer.Text = "FORCE TRANSFER";
            this.btn_Transfer.UseVisualStyleBackColor = true;
            this.btn_Transfer.Click += new System.EventHandler(this.btn_Transfer_Click);
            // 
            // steamPathLabel
            // 
            this.steamPathLabel.AutoSize = true;
            this.steamPathLabel.Location = new System.Drawing.Point(5, 87);
            this.steamPathLabel.Name = "steamPathLabel";
            this.steamPathLabel.Size = new System.Drawing.Size(128, 15);
            this.steamPathLabel.TabIndex = 10;
            this.steamPathLabel.Text = "Steam Launcher Path : ";
            // 
            // steam_TextBox
            // 
            this.steam_TextBox.Location = new System.Drawing.Point(139, 84);
            this.steam_TextBox.Name = "steam_TextBox";
            this.steam_TextBox.Size = new System.Drawing.Size(165, 23);
            this.steam_TextBox.TabIndex = 11;
            this.steam_TextBox.Text = "C:\\Program Files (x86)\\Steam";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 24);
            this.button1.TabIndex = 12;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // steam_GB
            // 
            this.steam_GB.Controls.Add(this.closeSteam_CheckBox);
            this.steam_GB.Controls.Add(this.steamPathLabel);
            this.steam_GB.Controls.Add(this.button1);
            this.steam_GB.Controls.Add(this.steam_TextBox);
            this.steam_GB.Location = new System.Drawing.Point(12, 114);
            this.steam_GB.Name = "steam_GB";
            this.steam_GB.Size = new System.Drawing.Size(384, 127);
            this.steam_GB.TabIndex = 13;
            this.steam_GB.TabStop = false;
            this.steam_GB.Text = "Steam";
            // 
            // closeSteam_CheckBox
            // 
            this.closeSteam_CheckBox.AutoSize = true;
            this.closeSteam_CheckBox.Checked = true;
            this.closeSteam_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.closeSteam_CheckBox.Location = new System.Drawing.Point(18, 45);
            this.closeSteam_CheckBox.Name = "closeSteam_CheckBox";
            this.closeSteam_CheckBox.Size = new System.Drawing.Size(181, 19);
            this.closeSteam_CheckBox.TabIndex = 13;
            this.closeSteam_CheckBox.Text = "Restart Steam before copying";
            this.closeSteam_CheckBox.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(408, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.configToolStripMenuItem.Text = "Config";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_Transfer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(408, 422);
            this.Controls.Add(this.steam_GB);
            this.Controls.Add(this.btn_Transfer);
            this.Controls.Add(this.consoleEnable);
            this.Controls.Add(this.watcherCheckBox);
            this.Controls.Add(this.pathSelectionGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Steam Userdata Duplicator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pathSelectionGroupBox.ResumeLayout(false);
            this.pathSelectionGroupBox.PerformLayout();
            this.steam_GB.ResumeLayout(false);
            this.steam_GB.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox to_TextBox;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.TextBox from_TextBox;
        private System.Windows.Forms.Button btn_BrowseFrom;
        private System.Windows.Forms.Button btn_BrowseTo;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox pathSelectionGroupBox;
        private System.Windows.Forms.CheckBox watcherCheckBox;
        private System.Windows.Forms.CheckBox consoleEnable;
        private System.Windows.Forms.Button btn_Transfer;
        private System.Windows.Forms.Label steamPathLabel;
        private System.Windows.Forms.TextBox steam_TextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox steam_GB;
        private System.Windows.Forms.CheckBox closeSteam_CheckBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
    }
}

