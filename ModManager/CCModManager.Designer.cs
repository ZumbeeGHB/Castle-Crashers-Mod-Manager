
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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.backupCCSavesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreCCSavesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeBox = new System.Windows.Forms.ToolStripComboBox();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.joinTheModdingDiscordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewGamebananaPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoImage = new System.Windows.Forms.PictureBox();
            this.importMods = new System.Windows.Forms.Button();
            this.progressLabel = new System.Windows.Forms.Label();
            this.mainProgress = new System.Windows.Forms.ProgressBar();
            this.runCC = new System.Windows.Forms.Button();
            this.modIcon = new System.Windows.Forms.PictureBox();
            this.modDescription = new System.Windows.Forms.TextBox();
            this.modList = new System.Windows.Forms.CheckedListBox();
            this.topCornerBG = new System.Windows.Forms.PictureBox();
            this.bottomCornerBG = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topCornerBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomCornerBG)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(902, 28);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(259, 6);
            // 
            // backupCCSavesToolStripMenuItem
            // 
            this.backupCCSavesToolStripMenuItem.Name = "backupCCSavesToolStripMenuItem";
            this.backupCCSavesToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.backupCCSavesToolStripMenuItem.Text = "Backup CC Saves";
            this.backupCCSavesToolStripMenuItem.Click += new System.EventHandler(this.backupCCSavesToolStripMenuItem_Click);
            // 
            // restoreCCSavesToolStripMenuItem
            // 
            this.restoreCCSavesToolStripMenuItem.Name = "restoreCCSavesToolStripMenuItem";
            this.restoreCCSavesToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.restoreCCSavesToolStripMenuItem.Text = "Restore CC Saves";
            this.restoreCCSavesToolStripMenuItem.Click += new System.EventHandler(this.restoreCCSavesToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeBox});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // themeBox
            // 
            this.themeBox.Name = "themeBox";
            this.themeBox.Size = new System.Drawing.Size(121, 28);
            this.themeBox.SelectedIndexChanged += new System.EventHandler(this.themeBox_SelectedIndexChanged);
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
            // logoImage
            // 
            this.logoImage.BackColor = System.Drawing.Color.Transparent;
            this.logoImage.BackgroundImage = global::ModManager.Properties.Resources.CCModManagerLogo_Light;
            this.logoImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoImage.Location = new System.Drawing.Point(24, 54);
            this.logoImage.Margin = new System.Windows.Forms.Padding(4);
            this.logoImage.Name = "logoImage";
            this.logoImage.Size = new System.Drawing.Size(632, 75);
            this.logoImage.TabIndex = 1;
            this.logoImage.TabStop = false;
            // 
            // importMods
            // 
            this.importMods.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.importMods.BackColor = System.Drawing.Color.White;
            this.importMods.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.importMods.Location = new System.Drawing.Point(675, 135);
            this.importMods.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.importMods.Name = "importMods";
            this.importMods.Size = new System.Drawing.Size(220, 37);
            this.importMods.TabIndex = 4;
            this.importMods.Text = "Install Mod";
            this.importMods.UseVisualStyleBackColor = false;
            this.importMods.Click += new System.EventHandler(this.importMods_Click);
            // 
            // progressLabel
            // 
            this.progressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressLabel.Location = new System.Drawing.Point(24, 582);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(645, 15);
            this.progressLabel.TabIndex = 5;
            this.progressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainProgress
            // 
            this.mainProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainProgress.Location = new System.Drawing.Point(24, 609);
            this.mainProgress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainProgress.Name = "mainProgress";
            this.mainProgress.Size = new System.Drawing.Size(276, 25);
            this.mainProgress.TabIndex = 6;
            // 
            // runCC
            // 
            this.runCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.runCC.BackColor = System.Drawing.Color.White;
            this.runCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.runCC.Location = new System.Drawing.Point(675, 176);
            this.runCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.runCC.Name = "runCC";
            this.runCC.Size = new System.Drawing.Size(220, 37);
            this.runCC.TabIndex = 7;
            this.runCC.Text = "Run Castle Crashers";
            this.runCC.UseVisualStyleBackColor = false;
            this.runCC.Click += new System.EventHandler(this.runCC_Click);
            // 
            // modIcon
            // 
            this.modIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.modIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modIcon.Location = new System.Drawing.Point(469, 135);
            this.modIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modIcon.Name = "modIcon";
            this.modIcon.Size = new System.Drawing.Size(200, 150);
            this.modIcon.TabIndex = 8;
            this.modIcon.TabStop = false;
            // 
            // modDescription
            // 
            this.modDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modDescription.Location = new System.Drawing.Point(469, 292);
            this.modDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modDescription.Multiline = true;
            this.modDescription.Name = "modDescription";
            this.modDescription.ReadOnly = true;
            this.modDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.modDescription.Size = new System.Drawing.Size(200, 278);
            this.modDescription.TabIndex = 9;
            // 
            // modList
            // 
            this.modList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modList.BackColor = System.Drawing.SystemColors.Window;
            this.modList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.modList.FormattingEnabled = true;
            this.modList.IntegralHeight = false;
            this.modList.Location = new System.Drawing.Point(24, 135);
            this.modList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modList.Name = "modList";
            this.modList.Size = new System.Drawing.Size(439, 435);
            this.modList.TabIndex = 10;
            this.modList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.modList_ItemChecked);
            this.modList.SelectedIndexChanged += new System.EventHandler(this.modList_SelectedIndexChanged);
            // 
            // topCornerBG
            // 
            this.topCornerBG.BackColor = System.Drawing.Color.Transparent;
            this.topCornerBG.BackgroundImage = global::ModManager.Properties.Resources.ModManagerBG_A_Light;
            this.topCornerBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.topCornerBG.Location = new System.Drawing.Point(0, 0);
            this.topCornerBG.Margin = new System.Windows.Forms.Padding(4);
            this.topCornerBG.Name = "topCornerBG";
            this.topCornerBG.Size = new System.Drawing.Size(430, 430);
            this.topCornerBG.TabIndex = 11;
            this.topCornerBG.TabStop = false;
            // 
            // bottomCornerBG
            // 
            this.bottomCornerBG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bottomCornerBG.BackColor = System.Drawing.Color.Transparent;
            this.bottomCornerBG.BackgroundImage = global::ModManager.Properties.Resources.ModManagerBG_B_Light;
            this.bottomCornerBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bottomCornerBG.Location = new System.Drawing.Point(235, 264);
            this.bottomCornerBG.Margin = new System.Windows.Forms.Padding(4);
            this.bottomCornerBG.Name = "bottomCornerBG";
            this.bottomCornerBG.Size = new System.Drawing.Size(667, 375);
            this.bottomCornerBG.TabIndex = 12;
            this.bottomCornerBG.TabStop = false;
            // 
            // CCModManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(902, 633);
            this.Controls.Add(this.modList);
            this.Controls.Add(this.modDescription);
            this.Controls.Add(this.modIcon);
            this.Controls.Add(this.runCC);
            this.Controls.Add(this.mainProgress);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.importMods);
            this.Controls.Add(this.logoImage);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.topCornerBG);
            this.Controls.Add(this.bottomCornerBG);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(920, 680);
            this.Name = "CCModManager";
            this.Text = "Castle Crashers Mod Manager v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topCornerBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomCornerBG)).EndInit();
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
        private System.Windows.Forms.PictureBox logoImage;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
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
        private System.Windows.Forms.PictureBox topCornerBG;
        private System.Windows.Forms.PictureBox bottomCornerBG;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox themeBox;
    }
}

