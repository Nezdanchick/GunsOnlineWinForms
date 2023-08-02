using GunsOnlineWinForms.Properties;
using NSFW;
using static System.Net.Mime.MediaTypeNames;

namespace GunsOnlineWinForms
{
    public partial class Lobby : CustomForm
    {
        private readonly MainForm _mainForm = new();

        public Lobby() : base(true, false, false)
        {
            InitializeComponent();
            TextIP.Text = Settings.Default.IPAddress;
            TextName.Text = Settings.Default.Username;
            // Icon setup
            IntPtr handle = Resources.icon.GetHicon();
            Icon = Icon.FromHandle(handle);
            // Controls setup
            ButtonHost.Select();
            LinkIPCopy.DisableSelect();
            LinkIPShow.DisableSelect();
            TextName.DisableSelect();
            TextIP.DisableSelect();

            User.Current.Client.OnConnect += () =>
            {
                MessageBox.Show("Client connected!");
            };
            User.Current.Server.OnConnect += () =>
            {
                MessageBox.Show("Server connected!");
            };
        }

        private void ShowMainForm()
        {
            Hide();
            _mainForm.ShowDialog();
            Show();
        }

        private void ButtonOffline_Click(object sender, EventArgs e)
        {
            ButtonCreate_Click(sender, e);
            ButtonConnect_Click(sender, e);
        }

        private void LinkIPCopy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(Address.LocalIP.ToString());
            var text = LinkIPCopy.Text;
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
            MessageBox.Show(Address.LocalIP.ToString());
        }
        private bool _connected = false;
        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            if (!_connected)
            {
                User.Current.Client.Connect(TextIP.Text);
                _connected = true;
            }
            ShowMainForm();
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            var endPoint = User.Current.Server.Start(Address.DefaultPort);
            MessageBox.Show($"IP: {endPoint.Address}\nPort: {endPoint.Port}\nCopied to clipboard");
            Clipboard.SetText(endPoint.ToString());
            User.Current.Server.ListenAsync();
            TextIP.Text = endPoint.ToString();
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
