namespace MBR_Fix
{
    partial class MainApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApp));
            this.ddDriveLetter = new System.Windows.Forms.ComboBox();
            this.lblDrive = new System.Windows.Forms.Label();
            this.btnFix = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lnkAbout = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // ddDriveLetter
            // 
            this.ddDriveLetter.FormattingEnabled = true;
            this.ddDriveLetter.Items.AddRange(new object[] {
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J"});
            this.ddDriveLetter.Location = new System.Drawing.Point(153, 71);
            this.ddDriveLetter.Name = "ddDriveLetter";
            this.ddDriveLetter.Size = new System.Drawing.Size(50, 21);
            this.ddDriveLetter.TabIndex = 0;
            // 
            // lblDrive
            // 
            this.lblDrive.AutoSize = true;
            this.lblDrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrive.Location = new System.Drawing.Point(12, 71);
            this.lblDrive.Name = "lblDrive";
            this.lblDrive.Size = new System.Drawing.Size(135, 17);
            this.lblDrive.TabIndex = 2;
            this.lblDrive.Text = "Select a drive to fix :";
            // 
            // btnFix
            // 
            this.btnFix.BackColor = System.Drawing.Color.Transparent;
            this.btnFix.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFix.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFix.Location = new System.Drawing.Point(209, 55);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(53, 37);
            this.btnFix.TabIndex = 3;
            this.btnFix.Text = "Scan and Fix";
            this.btnFix.UseVisualStyleBackColor = false;
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 52);
            this.label2.TabIndex = 4;
            this.label2.Text = "This tool attempts to recover the boot partition\r\n of an external harddrive requi" +
    "ring to be formatted\r\n before being used. Do not format first !\r\nThis also recov" +
    "ers drives hidden from \'Explorer\'";
            // 
            // lnkAbout
            // 
            this.lnkAbout.AutoSize = true;
            this.lnkAbout.Location = new System.Drawing.Point(0, 107);
            this.lnkAbout.Name = "lnkAbout";
            this.lnkAbout.Size = new System.Drawing.Size(35, 13);
            this.lnkAbout.TabIndex = 5;
            this.lnkAbout.TabStop = true;
            this.lnkAbout.Text = "About";
            this.lnkAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAbout_LinkClicked);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(267, 129);
            this.Controls.Add(this.lnkAbout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFix);
            this.Controls.Add(this.lblDrive);
            this.Controls.Add(this.ddDriveLetter);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainApp";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "CyB1nary MBR Restore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddDriveLetter;
        private System.Windows.Forms.Label lblDrive;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lnkAbout;
    }
}

