
namespace ModManager
{
    partial class CCModManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCCDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openModFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.joinTheModdingDiscordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewGamebananaPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.importMods = new System.Windows.Forms.Button();
            this.progressLabel = new System.Windows.Forms.Label();
            this.mainProgress = new System.Windows.Forms.ProgressBar();
            this.runCC = new System.Windows.Forms.Button();
            this.modIcon = new System.Windows.Forms.PictureBox();
            this.modDescription = new System.Windows.Forms.TextBox();
            this.modList = new System.Windows.Forms.CheckedListBox();
            this.restoreCCSavesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupCCSavesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(920, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openCCDirectoryToolStripMenuItem,
            this.openModFolderToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.toolStripSeparator1,
            this.backupCCSavesToolStripMenuItem,
            this.restoreCCSavesToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openCCDirectoryToolStripMenuItem
            // 
            this.openCCDirectoryToolStripMenuItem.Name = "openCCDirectoryToolStripMenuItem";
            this.openCCDirectoryToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.openCCDirectoryToolStripMenuItem.Text = "Set Castle Crashers Path";
            this.openCCDirectoryToolStripMenuItem.Click += new System.EventHandler(this.openCCDirectoryToolStripMenuItem_Click);
            // 
            // openModFolderToolStripMenuItem
            // 
            this.openModFolderToolStripMenuItem.Name = "openModFolderToolStripMenuItem";
            this.openModFolderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openModFolderToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.openModFolderToolStripMenuItem.Text = "Open Mod Folder";
            this.openModFolderToolStripMenuItem.Click += new System.EventHandler(this.openModFolderToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightModeToolStripMenuItem,
            this.darkModeToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // lightModeToolStripMenuItem
            // 
            this.lightModeToolStripMenuItem.CheckOnClick = true;
            this.lightModeToolStripMenuItem.Name = "lightModeToolStripMenuItem";
            this.lightModeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.lightModeToolStripMenuItem.Text = "Light Mode";
            this.lightModeToolStripMenuItem.CheckedChanged += new System.EventHandler(this.switchDisplayColorToolStripMenuItem_CheckedChanged);
            // 
            // darkModeToolStripMenuItem
            // 
            this.darkModeToolStripMenuItem.CheckOnClick = true;
            this.darkModeToolStripMenuItem.Name = "darkModeToolStripMenuItem";
            this.darkModeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.darkModeToolStripMenuItem.Text = "Dark Mode";
            this.darkModeToolStripMenuItem.CheckedChanged += new System.EventHandler(this.switchDisplayColorToolStripMenuItem_CheckedChanged);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.joinTheModdingDiscordToolStripMenuItem,
            this.viewGamebananaPageToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // joinTheModdingDiscordToolStripMenuItem
            // 
            this.joinTheModdingDiscordToolStripMenuItem.Name = "joinTheModdingDiscordToolStripMenuItem";
            this.joinTheModdingDiscordToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.joinTheModdingDiscordToolStripMenuItem.Text = "Join the Modding Discord";
            this.joinTheModdingDiscordToolStripMenuItem.Click += new System.EventHandler(this.joinTheModdingDiscordToolStripMenuItem_Click);
            // 
            // viewGamebananaPageToolStripMenuItem
            // 
            this.viewGamebananaPageToolStripMenuItem.Name = "viewGamebananaPageToolStripMenuItem";
            this.viewGamebananaPageToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.viewGamebananaPageToolStripMenuItem.Text = "View Gamebanana Page";
            this.viewGamebananaPageToolStripMenuItem.Click += new System.EventHandler(this.viewGamebananaPageToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.BackgroundImage = global::ModManager.Properties.Resources.CCModManagerLogo1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(24, 54);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(632, 75);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // importMods
            // 
            this.importMods.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.importMods.Location = new System.Drawing.Point(683, 136);
            this.importMods.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.importMods.Name = "importMods";
            this.importMods.Size = new System.Drawing.Size(215, 37);
            this.importMods.TabIndex = 4;
            this.importMods.Text = "Install Mod";
            this.importMods.UseVisualStyleBackColor = true;
            this.importMods.Click += new System.EventHandler(this.importMods_Click);
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(21, 585);
            this.progressLabel.MinimumSize = new System.Drawing.Size(655, 0);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(655, 16);
            this.progressLabel.TabIndex = 5;
            this.progressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainProgress
            // 
            this.mainProgress.Location = new System.Drawing.Point(24, 610);
            this.mainProgress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainProgress.Name = "mainProgress";
            this.mainProgress.Size = new System.Drawing.Size(312, 25);
            this.mainProgress.TabIndex = 6;
            // 
            // runCC
            // 
            this.runCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.runCC.Location = new System.Drawing.Point(683, 177);
            this.runCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.runCC.Name = "runCC";
            this.runCC.Size = new System.Drawing.Size(215, 37);
            this.runCC.TabIndex = 7;
            this.runCC.Text = "Run Castle Crashers";
            this.runCC.UseVisualStyleBackColor = true;
            this.runCC.Click += new System.EventHandler(this.runCC_Click);
            // 
            // modIcon
            // 
            this.modIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.modIcon.Location = new System.Drawing.Point(527, 136);
            this.modIcon.Name = "modIcon";
            this.modIcon.Size = new System.Drawing.Size(150, 150);
            this.modIcon.TabIndex = 8;
            this.modIcon.TabStop = false;
            // 
            // modDescription
            // 
            this.modDescription.Location = new System.Drawing.Point(527, 292);
            this.modDescription.Multiline = true;
            this.modDescription.Name = "modDescription";
            this.modDescription.ReadOnly = true;
            this.modDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.modDescription.Size = new System.Drawing.Size(150, 285);
            this.modDescription.TabIndex = 9;
            // 
            // modList
            // 
            this.modList.BackColor = System.Drawing.SystemColors.Window;
            this.modList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.modList.FormattingEnabled = true;
            this.modList.IntegralHeight = false;
            this.modList.Location = new System.Drawing.Point(24, 136);
            this.modList.MinimumSize = new System.Drawing.Size(497, 418);
            this.modList.Name = "modList";
            this.modList.Size = new System.Drawing.Size(497, 441);
            this.modList.TabIndex = 10;
            this.modList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.modList_ItemChecked);
            this.modList.SelectedIndexChanged += new System.EventHandler(this.modList_SelectedIndexChanged);
            // 
            // restoreCCSavesToolStripMenuItem
            // 
            this.restoreCCSavesToolStripMenuItem.Name = "restoreCCSavesToolStripMenuItem";
            this.restoreCCSavesToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.restoreCCSavesToolStripMenuItem.Text = "Restore CC Saves";
            this.restoreCCSavesToolStripMenuItem.Click += new System.EventHandler(this.restoreCCSavesToolStripMenuItem_Click);
            // 
            // backupCCSavesToolStripMenuItem
            // 
            this.backupCCSavesToolStripMenuItem.Name = "backupCCSavesToolStripMenuItem";
            this.backupCCSavesToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.backupCCSavesToolStripMenuItem.Text = "Backup CC Saves";
            this.backupCCSavesToolStripMenuItem.Click += new System.EventHandler(this.backupCCSavesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(259, 6);
            // 
            // CCModManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::ModManager.Properties.Resources.ModManagerBG1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(920, 641);
            this.Controls.Add(this.modList);
            this.Controls.Add(this.modDescription);
            this.Controls.Add(this.modIcon);
            this.Controls.Add(this.runCC);
            this.Controls.Add(this.mainProgress);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.importMods);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "CCModManager";
            this.Text = "Castle Crashers Mod Manager v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCCDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem joinTheModdingDiscordToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkModeToolStripMenuItem;
        private System.Windows.Forms.Button importMods;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.ProgressBar mainProgress;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openModFolderToolStripMenuItem;
        private System.Windows.Forms.Button runCC;
        private System.Windows.Forms.ToolStripMenuItem viewGamebananaPageToolStripMenuItem;
        private System.Windows.Forms.PictureBox modIcon;
        private System.Windows.Forms.TextBox modDescription;
        private System.Windows.Forms.CheckedListBox modList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem backupCCSavesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreCCSavesToolStripMenuItem;
    }
}

