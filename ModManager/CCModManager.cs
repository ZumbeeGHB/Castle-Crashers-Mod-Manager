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
        string modFolder, backupFolder, dataFolder, userDataFolder;
        string importText;
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
            userDataFolder = $"C:\\Program Files (x86)\\Steam\\userdata";

            // Load Settings
            dataFolder = Properties.Settings.Default.ccDataPath;
            lightMode = Properties.Settings.Default.lightMode;
            importText = importMods.Text;
            UpdateDisplayType();
            RefreshModList();
            UpdateImportButtonText(false);
            loading = false;
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
                CopyDirectory(dataFolder, backupFolder, false, $"Backing up Files from '{Path.GetFileName(dataFolder)}': ");
            }
        }
        private void joinTheModdingDiscordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenLink("https://discord.gg/NdPYPbUncU");
        }
        private void viewGamebananaPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenLink("https://gamebanana.com/games/9330");
        }
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshModList();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 box = new AboutBox1();
            box.ShowDialog();
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
        public void UpdateDisplayType()
        {
            // Update the menu strip buttons
            lightModeToolStripMenuItem.Enabled = !lightMode;
            lightModeToolStripMenuItem.Checked = lightMode;
            darkModeToolStripMenuItem.Enabled = lightMode;
            darkModeToolStripMenuItem.Checked = !lightMode;

            // TO DO: Actually uhhhh make this work by updating all the UI stuff
        }
        public void UpdateImportButtonText(bool modChecked)
        {
            importMods.Text = "Restore To Vanilla";
            if (modChecked) importMods.Text = importText;
        }
        public void RefreshModList()
        {
            modList.Items.Clear();
            if (Directory.Exists(modFolder))
            {
                foreach (string folder in Directory.GetDirectories(modFolder))
                {
                    // Add new mod to list
                    modList.Items.Add(Path.GetFileName(folder));
                }
            }
            else Directory.CreateDirectory(modFolder);
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
                // Restore backup
                Directory.Delete(dataFolder, true);
                mainProgress.Value = 0;
                mainProgress.Maximum = DirectoryFileMeasurement(backupFolder, false);
                CopyDirectory(backupFolder, dataFolder, false, "Restoring Backup Files: ");
                for (int i = 0; i < modList.Items.Count; i++)
                {
                    // Import each mod
                    if (modList.GetItemChecked(i))
                    {
                        string modName = modList.Items[i].ToString();
                        mainProgress.Value = 0;
                        mainProgress.Maximum = DirectoryFileMeasurement(modFolder + $"\\{modName}", true);
                        CopyDirectory(modFolder + $"\\{modName}", dataFolder, true, $"Importing '{modName}' Files: ");
                    }
                }
            }
            else
            {
                // If no data directory is found, or doesn't end with 'data', show error.
                MessageBox.Show($"Failed to find Castle Crashers 'data' folder...");
            }
        }
        private void openModFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(modFolder)) Directory.CreateDirectory(modFolder);
            OpenFileOrFolder(modFolder);
        }

        void CopyDirectory(string sourceDir, string destinationDir, bool directoriesOnly, string progressMessage)
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
                    progressLabel.Text = $"{progressMessage}{Path.GetFileName(file)}";
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
                CopyDirectory(subDir.FullName, newDestinationDir, false, progressMessage);
            }
        }

        private void runCC_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(dataFolder))
            {
                string trueDirectory = Path.GetDirectoryName(dataFolder);
                if (Directory.Exists(trueDirectory))
                {
                    if (File.Exists(trueDirectory + "\\castle.exe"))
                        OpenFileOrFolder(trueDirectory + "\\castle.exe");
                    else
                        MessageBox.Show($"Failed to find castle.exe in:{Environment.NewLine}{trueDirectory}");
                }
            }
            else MessageBox.Show($"Failed to find Castle Crashers Directory at:{Environment.NewLine}{dataFolder}");
        }
        void OpenFileOrFolder(string path)
        {
            // Acts like if you had double clicked something in File Explorer
            var process = new Process();
            try
            {
                process.StartInfo = new ProcessStartInfo()
                {
                    UseShellExecute = true,
                    FileName = path
                };
                process.Start();
            }
            catch { }
            process.Dispose();
        }

        private void modList_ItemChecked(object sender, ItemCheckEventArgs e)
        {
            if (loading) return;
            loading = true;
            for (int i = 0; i < modList.Items.Count; i++)
            {
                if (i != e.Index) modList.SetItemChecked(i, false);
            }
            bool modChecked = false;
            if (e.NewValue == CheckState.Checked) modChecked = true;
            UpdateImportButtonText(modChecked);
            loading = false;
        }

        private void modList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string modPath = modFolder + $"\\{modList.Items[modList.SelectedIndex].ToString()}";
                if (File.Exists(modPath + "\\Description.txt"))
                {
                    // update mod description
                    modDescription.Text = File.ReadAllText(modPath + "\\Description.txt");
                }
                else modDescription.Text = "";
                if (File.Exists(modPath + "\\Icon.png"))
                {
                    // Update mod icon
                    Image icon = Image.FromFile(modPath + "\\Icon.png");
                    modIcon.BackgroundImage = icon;
                }
                else modIcon.BackgroundImage = null;
            } catch
            {
                modIcon.BackgroundImage = null;
                modDescription.Text = "";
            }
        }

        private void restoreCCSavesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Take saves in Base Directory and move them to their respective locations
            string a = AppDomain.CurrentDomain.BaseDirectory;
            foreach (string file in Directory.GetFiles(a))
            {
                string fileName = Path.GetFileName(file);
                if (fileName.StartsWith("cc_save.") && fileName.EndsWith(".dat"))
                {
                    string userID = fileName.Substring(8, fileName.Length - 12);
                    if (Directory.Exists(userDataFolder + $"\\{userID}\\204360\\remote"))
                    {
                        File.Copy(file, userDataFolder + $"\\{userID}\\204360\\remote\\cc_save.dat", true);
                        Debug.WriteLine($"Copied File :{file} to new path: {userDataFolder}\\{userID}\\204360\\remote\\cc_save.dat");
                    }
                }
            }
        }

        private void backupCCSavesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Copy CC Saves to .exe location
            if (Directory.Exists(userDataFolder))
            {
                bool backedAtLeastOne = false;
                foreach (string userID in Directory.GetDirectories(userDataFolder))
                {
                    if (File.Exists(userID + "\\204360\\remote\\cc_save.dat"))
                    {
                        backedAtLeastOne = true;
                        File.Copy
                            (
                            userID + "\\204360\\remote\\cc_save.dat",
                            AppDomain.CurrentDomain.BaseDirectory + $"\\cc_save.{Path.GetFileName(userID)}.dat", true
                            );
                        Debug.WriteLine($"Copied File: {userID}\\204360\\remote\\cc_save.dat to new path: {AppDomain.CurrentDomain.BaseDirectory}\\cc_save.{Path.GetFileName(userID)}.dat");
                    }
                }
                if (backedAtLeastOne) MessageBox.Show($"Backed saves to: {AppDomain.CurrentDomain.BaseDirectory}");
            }
            else MessageBox.Show($"No Directory found at:{Environment.NewLine}{userDataFolder}");
        }

        void OpenLink(string target)
        {
            try
            {
                Process link = Process.Start(target);
                link.WaitForExit();
                link.Dispose();
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
