using GunsOnlineWinForms.Properties;

namespace GunsOnlineWinForms
{
    public partial class MainForm : CustomForm
    {
        readonly Chat _chat;
        public MainForm()
        {
            InitializeComponent();
            _chat = new Chat();
            FormBorderStyle = FormBorderStyle.None;
            TextChat.Hide();
            // Icon setup
            IntPtr handle = Resources.icon.GetHicon();
            Icon = Icon.FromHandle(handle);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    _chat.ShowDialog();
                    break;
            }
        }

        private void ChatFade_Tick(object sender, EventArgs e)
        {
            TextChat.Hide();
            ChatFade.Stop();
        }

        private void TextChat_TextChanged(object sender, EventArgs e)
        {
            TextChat.Show();
            ChatFade.Start();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            TextChat.Text = _chat.ChatText;
        }
    }
}
