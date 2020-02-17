using System;
using System.Windows.Forms;

using System.Diagnostics;
using System.IO;

namespace MBR_Fix
{
    public partial class MainApp : Form
    {
        public MainApp()
        {
            InitializeComponent();
        }

        String driveLetter;
        public void checkDisk()
        {
            driveLetter = ddDriveLetter.Text;
            ProcessStartInfo chkDsk = new ProcessStartInfo();
            chkDsk.FileName = "cmd.exe";
            chkDsk.WindowStyle = ProcessWindowStyle.Normal;
            chkDsk.Arguments = "/c chkdsk /F "+ driveLetter + ":";
            //chkDsk.CreateNoWindow = false;
            Process.Start(chkDsk).WaitForExit();
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            try
            {
                checkDisk();
                MessageBox.Show("Disk Drive " + driveLetter + " has been scanned and recovered successfully", "Cleaning complete");
            }
            catch (System.Exception ex)
            { MessageBox.Show(ex.ToString());}
        }
        private void lnkAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAbout frm = new FrmAbout();
            frm.Show();
        }
    }
}
