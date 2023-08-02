using System.Windows.Forms.Design;

namespace GunsOnlineWinForms
{
    public partial class CustomForm : Form
    {
        private readonly Panel _panelHeader = new();     // window top panel

        private readonly Button _buttonClose = new();    // close form
        private readonly Button _buttonMaximize = new(); // maximize or minimize form
        private readonly Button _buttonHide = new();     // hide form to taskbar

        private const string _close = "x";
        private const string _hide = "=";
        private const string _max = "+";
        private const string _min = "-";

        private bool Maximized => WindowState == FormWindowState.Maximized;
        private readonly bool _canMaximize;

        private const int _size = 22;
        private int _xpos = 0;

        public CustomForm(bool canClose = true, bool canHide = true, bool canMaximize = true)
        {
            // init form
            InitializeComponent();

            BackColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;

            // init components
            InitializePanelHeader();
            if (canClose)
                InitializeButton(_buttonClose, _close,
                             () => Close());
            if (canHide)
                InitializeButton(_buttonHide, _hide,
                             () => ButtonHide());
            if (canMaximize)
                InitializeButton(_buttonMaximize, _max,
                             () => ButtonMaximize());
            _canMaximize = canMaximize;
        }
        private void InitializeButton(Button button, string text, Action action)
        {
            _panelHeader.Controls.Add(button);

            button.Size = new Size(_size, _size);
            button.BackColor = Color.Transparent;
            button.ForeColor = Color.Black;
            button.Text = text;
            button.Location = new Point(_xpos, 0);
            button.Click += (object? sender, EventArgs e) => action.Invoke();
            _xpos += _size;
            button.DisableSelect();
        }
        private void ButtonMaximize()
        {
            if (!_canMaximize) return;
            _buttonMaximize.Text = Maximized ? _max : _min;
            WindowState = Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }
        private void ButtonHide() =>
            WindowState = FormWindowState.Minimized;

        #region Header
        private Point difference = Point.Empty;

        private void InitializePanelHeader()
        {
            Controls.Add(_panelHeader);

            _panelHeader.Location = Point.Empty;
            _panelHeader.Size = new(0, _size);
            _panelHeader.BackColor = Color.Gray;
            _panelHeader.Dock = DockStyle.Top;
            _panelHeader.MouseDown += Header_MouseDown;
            _panelHeader.MouseMove += Header_MouseMove;
            _panelHeader.DoubleClick += (object? sender, EventArgs e) => ButtonMaximize();
        }
        private void Header_MouseDown(object? sender, MouseEventArgs e) =>
            difference = Location.Minus(MousePosition);
        private void Header_MouseMove(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Location = MousePosition.Plus(difference);
                if (Maximized)
                    ButtonMaximize();
            }
        }
        #endregion
    }
}
