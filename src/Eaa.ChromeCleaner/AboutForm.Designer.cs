namespace Eaa.ChromeCleaner
{
    partial class AboutForm
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
            System.Windows.Forms.PictureBox pictureBox1;
            System.Windows.Forms.Panel panel1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            this._websiteLinkLabel = new System.Windows.Forms.LinkLabel();
            this._versionLabel = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            panel1 = new System.Windows.Forms.Panel();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            pictureBox1.Image = global::Eaa.ChromeCleaner.Properties.Resources.AppImage;
            pictureBox1.Location = new System.Drawing.Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(229, 37);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel1.Controls.Add(this._websiteLinkLabel);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(this._versionLabel);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new System.Drawing.Point(13, 13);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(233, 156);
            panel1.TabIndex = 1;
            // 
            // _websiteLinkLabel
            // 
            this._websiteLinkLabel.AutoSize = true;
            this._websiteLinkLabel.Location = new System.Drawing.Point(4, 127);
            this._websiteLinkLabel.Name = "_websiteLinkLabel";
            this._websiteLinkLabel.Size = new System.Drawing.Size(222, 13);
            this._websiteLinkLabel.TabIndex = 5;
            this._websiteLinkLabel.TabStop = true;
            this._websiteLinkLabel.Text = "http://github.com/eallegretta/chrome-cleaner";
            this._websiteLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._websiteLinkLabel_LinkClicked);
            // 
            // label3
            // 
            label3.Dock = System.Windows.Forms.DockStyle.Top;
            label3.Location = new System.Drawing.Point(0, 100);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(229, 13);
            label3.TabIndex = 4;
            label3.Text = "Enrique Alejandro Allegretta";
            label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Dock = System.Windows.Forms.DockStyle.Top;
            label2.Location = new System.Drawing.Point(0, 73);
            label2.Name = "label2";
            label2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            label2.Size = new System.Drawing.Size(229, 27);
            label2.TabIndex = 3;
            label2.Text = "Copyright - 2017";
            label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _versionLabel
            // 
            this._versionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this._versionLabel.Location = new System.Drawing.Point(0, 50);
            this._versionLabel.Name = "_versionLabel";
            this._versionLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this._versionLabel.Size = new System.Drawing.Size(229, 23);
            this._versionLabel.TabIndex = 2;
            this._versionLabel.Text = "v1.0.0";
            this._versionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.Dock = System.Windows.Forms.DockStyle.Top;
            label1.Location = new System.Drawing.Point(0, 37);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(229, 13);
            label1.TabIndex = 1;
            label1.Text = "Chrome Cleaner";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 181);
            this.Controls.Add(panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label _versionLabel;
        private System.Windows.Forms.LinkLabel _websiteLinkLabel;
    }
}