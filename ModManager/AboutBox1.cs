using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModManager
{
    partial class AboutBox1 : Form
    {
        private CCModManager main;
        public AboutBox1(CCModManager parent)
        {
            InitializeComponent();
            main = parent;
            this.Text = String.Format("About {0}", AssemblyTitle);
            this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            //this.labelProductName.Text = AssemblyProduct;
            //this.labelCopyright.Text = AssemblyCopyright;
            //this.labelCompanyName.Text = AssemblyCompany;
            //this.labelDescription.Text = AssemblyDescription;
        }
        private void AboutBox1_Load(object sender, EventArgs e)
        {
            UpdateDisplayTheme();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLink("https://www.youtube.com/@ZumbeeYTB");
        }
        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLink("https://symmdev.itch.io/");
        }
        private void OpenLink(string target)
        {
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
        private void UpdateDisplayTheme()
        {
            string theme = Properties.Settings.Default.themeType;
            Color textCol = main.menuThemes[theme][2];
            try { BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject($"About_{theme}"); }
            catch { MessageBox.Show("Failed to load Background Image..."); }
            labelAuthors.ForeColor = textCol;
            labelDescription.ForeColor = textCol;
            labelVersion.ForeColor = textCol;

            // Hardcoded Link Colors
            Color linkColor = Color.White;
            Color visitedColor = Color.Maroon;
            switch (theme)
            {
                case "Light":
                    linkColor = Color.Red;
                    visitedColor = Color.Maroon;
                    break;
                case "Dark":
                    linkColor = Color.LightCoral;
                    visitedColor = Color.Maroon;
                    break;
            }
            linkZumbee.LinkColor = linkColor;
            linkZumbee.VisitedLinkColor = visitedColor;
            linkSymm.LinkColor = linkColor;
            linkSymm.VisitedLinkColor = visitedColor;
        }

        #region Assembly Attribute Accessors
        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion
    }
}
