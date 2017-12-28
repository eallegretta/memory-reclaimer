using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace Eaa.ChromeCleaner
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();

            _versionLabel.Text = $"v{Assembly.GetEntryAssembly().GetName().Version}";
        }

        private void _websiteLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(_websiteLinkLabel.Text);
        }
    }
}
