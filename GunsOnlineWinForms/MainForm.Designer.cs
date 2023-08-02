namespace GunsOnlineWinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox = new PictureBox();
            TextChat = new Label();
            ChatFade = new System.Windows.Forms.Timer(components);
            GameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.Black;
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Margin = new Padding(4, 3, 4, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(933, 519);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // TextChat
            // 
            TextChat.AutoSize = true;
            TextChat.BackColor = Color.Black;
            TextChat.ForeColor = Color.White;
            TextChat.Location = new Point(28, 58);
            TextChat.Margin = new Padding(4, 0, 4, 0);
            TextChat.Name = "TextChat";
            TextChat.Size = new Size(32, 15);
            TextChat.TabIndex = 2;
            TextChat.Text = "Chat";
            TextChat.TextChanged += TextChat_TextChanged;
            // 
            // ChatFade
            // 
            ChatFade.Enabled = true;
            ChatFade.Interval = 15000;
            ChatFade.Tick += ChatFade_Tick;
            // 
            // GameTimer
            // 
            GameTimer.Enabled = true;
            GameTimer.Interval = 20;
            GameTimer.Tick += GameTimer_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(TextChat);
            Controls.Add(pictureBox);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "Bull Shoot";
            KeyDown += MainForm_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private Label TextChat;
        private System.Windows.Forms.Timer ChatFade;
        private System.Windows.Forms.Timer GameTimer;
    }
}

