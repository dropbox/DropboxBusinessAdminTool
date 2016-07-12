using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DfBAdminToolkit.Services;

namespace DfBAdminToolkit.View
{
    public partial class VersionWindow : Form
    {
        private GitHubRelease _release;

        public VersionWindow(GitHubRelease release)
        {
            _release = release;
            InitializeComponent();
            versionAlertText.Text = String.Format(@"Version {0} of the Admin Toolkit is now available!", _release.version.ToString());
            versionDetails.Text = String.Format(@"Release Notes:{0}{1}", Environment.NewLine, _release.description);
            if (_release.downloadUri != null)
            {
                downloadButton.Text = @"Download Release";
            }
            else
            {
                downloadButton.Text = @"View Details";
            }
        }

        private void downloadButton_Clicked(object sender, EventArgs e)
        {
            if (_release.downloadUri != null)
            {
                System.Diagnostics.Process.Start(_release.downloadUri.ToString());
                Application.Exit();
            }
            else
            {
                System.Diagnostics.Process.Start(_release.releaseUri.ToString());
            }
            this.Close();
        }

        private void dismissButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
