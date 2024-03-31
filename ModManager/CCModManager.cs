using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModManager
{
    public partial class CCModManager : Form
    {
        bool loading;
        string modFolder, backupFolder, dataFolder;
        bool lightMode;
        public CCModManager()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loading = true;

            // Define paths for Castle Crashers' Vanilla Data and Mods
            modFolder = AppDomain.CurrentDomain.BaseDirectory + "\\Mods";
            backupFolder = AppDomain.CurrentDomain.BaseDirectory + "\\Backup";

            // Load Settings
            dataFolder = Properties.Settings.Default.ccDataPath;
            lightMode = Properties.Settings.Default.lightMode;
            UpdateDisplayType();
            RefreshModList();
            UpdateImportButtonText();
            loading = false;
        }
        private ListViewItem ParseMod(string path)
        {
            ListViewItem item = new ListViewItem();
            item.Text = Path.GetFileName(path);
            return item;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 box = new AboutBox1();
            box.ShowDialog();
        }

        public void UpdateDisplayType()
        {
            // Update the menu strip buttons
            lightModeToolStripMenuItem.Enabled = !lightMode;
            lightModeToolStripMenuItem.Checked = lightMode;
            darkModeToolStripMenuItem.Enabled = lightMode;
            darkModeToolStripMenuItem.Checked = !lightMode;

            // TO DO: Actually uhhhh make this work by updating all the UI stuff
        }
        public void UpdateImportButtonText()
        {
            importMods.Text = "Restore To Vanilla";
            if (modList.CheckedItems.Count > 0)
            {
                importMods.Text = "Import Mods";
            }
        }
        public void RefreshModList()
        {
            modList.Items.Clear();
            if (Directory.Exists(modFolder))
            {
                foreach (string folder in Directory.GetDirectories(modFolder))
                {
                    // Add new mod to list
                    modList.Items.Add(ParseMod(folder));
                }
            }
            else Directory.CreateDirectory(modFolder);
        }

        private void openCCDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please select the location of the 'data' folder used by Castle Crashers" + Environment.NewLine +
                "This will also make a backup of the files for restoring them to vanilla.");

            FolderBrowserDialog open = new FolderBrowserDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                dataFolder = open.SelectedPath;
                Properties.Settings.Default.ccDataPath = dataFolder;
                Properties.Settings.Default.Save();
                if (Directory.Exists(backupFolder)) Directory.Delete(backupFolder, true);
                mainProgress.Value = 0;
                mainProgress.Maximum = DirectoryFileMeasurement(dataFolder, false);
                CopyDirectory(dataFolder, backupFolder, false);
            }
        }

        private void switchDisplayColorToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            // Use loading bool to prevent this function from repeating itself
            if (loading) return;
            loading = true;
            lightMode = !lightMode;
            Properties.Settings.Default.lightMode = lightMode;
            Properties.Settings.Default.Save();
            UpdateDisplayType();
            loading = false;
        }

        private void importMods_Click(object sender, EventArgs e)
        {
            // Restore backup folder before importing mods
            if (!Directory.Exists(backupFolder))
            {
                // If there is no backup made, prompt user to make one first
                openCCDirectoryToolStripMenuItem_Click(sender, e);
                return;
            }

            if (Directory.Exists(dataFolder)) 
            {
                // Warn the user if more than one mod is checked
                if (modList.CheckedItems.Count > 1)
                {
                    DialogResult dialogResult = MessageBox.Show(
                        $"Due to many mods having files that overlap, it's best" + Environment.NewLine +
                        $"to only use one mod at a time, install multiple?", "", MessageBoxButtons.YesNo);
                    if (dialogResult != DialogResult.Yes) return;
                }

                Directory.Delete(dataFolder, true);
                mainProgress.Value = 0;
                mainProgress.Maximum = DirectoryFileMeasurement(backupFolder, false);
                CopyDirectory(backupFolder, dataFolder, false);
                foreach (ListViewItem item in modList.CheckedItems)
                {
                    // Import each mod
                    mainProgress.Value = 0;
                    mainProgress.Maximum = DirectoryFileMeasurement(modFolder + $"\\{item.Text}", true);
                    CopyDirectory(modFolder + $"\\{item.Text}", dataFolder, true);
                }
            }
            else
            {
                // If no data directory is found, or doesn't end with 'data', show error.
                MessageBox.Show($"Failed to find Castle Crashers 'data' folder...");
            }
        }

        private void joinTheModdingDiscordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string target = "https://discord.gg/NdPYPbUncU";
            try
            {
                System.Diagnostics.Process.Start(target);
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshModList();
        }

        private void modList_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            UpdateImportButtonText();
        }

        private void openModFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(modFolder)) return;
            var process = new Process();
            try
            {
                process.StartInfo = new ProcessStartInfo()
                {
                    UseShellExecute = true,
                    FileName = modFolder
                };
                process.Start();
            }
            catch { }
            process.Dispose();
        }

        void CopyDirectory(string sourceDir, string destinationDir, bool directoriesOnly)
        {
            if (!Directory.Exists(destinationDir)) Directory.CreateDirectory(destinationDir);
            var dir = new DirectoryInfo(sourceDir);
            if (!dir.Exists)
                throw new DirectoryNotFoundException($"Source directory not found: {dir.FullName}");

            if (!directoriesOnly)
            {
                foreach (string file in Directory.GetFiles(sourceDir))
                {
                    string targetFilePath = Path.Combine(destinationDir, Path.GetFileName(file));
                    progressLabel.Text = $"Copying File: {Path.GetFileName(file)}";
                    File.Copy(file, targetFilePath, true);
                    mainProgress.Value++;
                    if (mainProgress.Value == mainProgress.Maximum) progressLabel.Text = "Done!";
                    progressLabel.Refresh();
                }
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            foreach (DirectoryInfo subDir in dirs)
            {
                string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
                CopyDirectory(subDir.FullName, newDestinationDir, false);
            }
        }
        static int DirectoryFileMeasurement(string dir, bool directoriesOnly)
        {
            int count = 0;
            if (!directoriesOnly) count += Directory.GetFiles(dir).Length;
            foreach (string subDir in Directory.GetDirectories(dir))
            {
                count += DirectoryFileMeasurement(subDir, false);
            }
            return count;
        }
    }
}
