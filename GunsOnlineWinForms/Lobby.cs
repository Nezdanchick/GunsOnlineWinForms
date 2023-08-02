using GunsOnlineWinForms.Properties;

namespace GunsOnlineWinForms
{
    public partial class Lobby : CustomForm
    {
        public Lobby() : base(true, false, false)
        {
            InitializeComponent();
            TextIP.Text = Settings.Default.IPAddress;
            TextName.Text = Settings.Default.Username;
            // Icon setup
            IntPtr handle = Resources.icon.GetHicon();
            Icon = Icon.FromHandle(handle);
            // Controls setup
            ButtonOffline.Select();
            LinkIPCopy.DisableSelect();
            LinkIPShow.DisableSelect();
            TextName.DisableSelect();
            TextIP.DisableSelect();
        }

        private void ShowMainForm()
        {
            Hide();
            new MainForm().ShowDialog();
            Show();
        }

        private void ButtonOffline_Click(object sender, EventArgs e) =>
            ShowMainForm();

        private void LinkIPCopy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var text = LinkIPCopy.Text;
            Clipboard.SetText(TextIP.Text);
            LinkIPCopy.Invoke(ChangeLinkText);
            async void ChangeLinkText()
            {
                LinkIPCopy.Text = "Copied";
                await Task.Delay(1000);
                LinkIPCopy.Text = text;
            }
        }
        private void LinkIPShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(TextIP.Text);
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
        }

        private void Lobby_FormClosing(object sender, FormClosingEventArgs e)
        {
            var host = TextIP.Text;
            if (host.Contains(':'))
                Settings.Default.IPAddress = host;
            Settings.Default.Username = TextName.Text;
            Settings.Default.Save();
        }
    }
}
