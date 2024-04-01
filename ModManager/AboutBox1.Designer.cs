
namespace ModManager
{
    partial class AboutBox1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelAuthors = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.linkZumbee = new System.Windows.Forms.LinkLabel();
            this.okButton = new System.Windows.Forms.Button();
            this.linkSymm = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelDescription
            // 
            this.labelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelDescription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(16, 143);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(915, 27);
            this.labelDescription.TabIndex = 0;
            this.labelDescription.Text = "ZumbeeStuff Mod Manager for Castle Crashers";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAuthors
            // 
            this.labelAuthors.BackColor = System.Drawing.Color.Transparent;
            this.labelAuthors.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthors.Location = new System.Drawing.Point(16, 200);
            this.labelAuthors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAuthors.Name = "labelAuthors";
            this.labelAuthors.Size = new System.Drawing.Size(915, 27);
            this.labelAuthors.TabIndex = 1;
            this.labelAuthors.Text = "A Zumbee and SymmDev collaboration";
            this.labelAuthors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelVersion
            // 
            this.labelVersion.BackColor = System.Drawing.Color.Transparent;
            this.labelVersion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.Location = new System.Drawing.Point(16, 257);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(915, 27);
            this.labelVersion.TabIndex = 2;
            this.labelVersion.Text = "Version";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkZumbee
            // 
            this.linkZumbee.BackColor = System.Drawing.Color.Transparent;
            this.linkZumbee.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkZumbee.LinkColor = System.Drawing.Color.Red;
            this.linkZumbee.Location = new System.Drawing.Point(16, 320);
            this.linkZumbee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkZumbee.Name = "linkZumbee";
            this.linkZumbee.Size = new System.Drawing.Size(451, 27);
            this.linkZumbee.TabIndex = 3;
            this.linkZumbee.TabStop = true;
            this.linkZumbee.Text = "Zumbee\'s Youtube Channel";
            this.linkZumbee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkZumbee.VisitedLinkColor = System.Drawing.Color.Maroon;
            this.linkZumbee.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.BackColor = System.Drawing.SystemColors.Control;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.okButton.Location = new System.Drawing.Point(831, 351);
            this.okButton.Margin = new System.Windows.Forms.Padding(4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 28);
            this.okButton.TabIndex = 25;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = false;
            // 
            // linkSymm
            // 
            this.linkSymm.BackColor = System.Drawing.Color.Transparent;
            this.linkSymm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSymm.LinkColor = System.Drawing.Color.Red;
            this.linkSymm.Location = new System.Drawing.Point(480, 320);
            this.linkSymm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkSymm.Name = "linkSymm";
            this.linkSymm.Size = new System.Drawing.Size(451, 27);
            this.linkSymm.TabIndex = 26;
            this.linkSymm.TabStop = true;
            this.linkSymm.Text = "Symm\'s Itch.io Page";
            this.linkSymm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkSymm.VisitedLinkColor = System.Drawing.Color.Maroon;
            this.linkSymm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // AboutBox1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ModManager.Properties.Resources.About_Light;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(947, 394);
            this.Controls.Add(this.linkSymm);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.linkZumbee);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelAuthors);
            this.Controls.Add(this.labelDescription);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox1";
            this.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AboutBox1";
            this.Load += new System.EventHandler(this.AboutBox1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelAuthors;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.LinkLabel linkZumbee;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.LinkLabel linkSymm;
    }
}
