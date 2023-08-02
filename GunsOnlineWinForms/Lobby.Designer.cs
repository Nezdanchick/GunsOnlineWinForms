namespace GunsOnlineWinForms
{
    partial class Lobby
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
            TextIP = new TextBox();
            ButtonConnect = new Button();
            ButtonCreate = new Button();
            ButtonHost = new Button();
            TextName = new TextBox();
            LinkIPCopy = new LinkLabel();
            LinkIPShow = new LinkLabel();
            SuspendLayout();
            // 
            // TextIP
            // 
            TextIP.BackColor = Color.White;
            TextIP.ForeColor = Color.Black;
            TextIP.Location = new Point(14, 63);
            TextIP.Margin = new Padding(4, 3, 4, 3);
            TextIP.Name = "TextIP";
            TextIP.Size = new Size(116, 23);
            TextIP.TabIndex = 2;
            TextIP.Text = "Address";
            // 
            // ButtonConnect
            // 
            ButtonConnect.BackColor = Color.White;
            ButtonConnect.ForeColor = Color.Black;
            ButtonConnect.Location = new Point(156, 61);
            ButtonConnect.Margin = new Padding(4, 3, 4, 3);
            ButtonConnect.Name = "ButtonConnect";
            ButtonConnect.Size = new Size(88, 27);
            ButtonConnect.TabIndex = 4;
            ButtonConnect.Text = "Connect";
            ButtonConnect.UseVisualStyleBackColor = false;
            ButtonConnect.Click += ButtonConnect_Click;
            // 
            // ButtonCreate
            // 
            ButtonCreate.BackColor = Color.White;
            ButtonCreate.ForeColor = Color.Black;
            ButtonCreate.Location = new Point(156, 91);
            ButtonCreate.Margin = new Padding(4, 3, 4, 3);
            ButtonCreate.Name = "ButtonCreate";
            ButtonCreate.Size = new Size(88, 27);
            ButtonCreate.TabIndex = 6;
            ButtonCreate.Text = "Create";
            ButtonCreate.UseVisualStyleBackColor = false;
            ButtonCreate.Click += ButtonCreate_Click;
            // 
            // ButtonOffline
            // 
            ButtonHost.BackColor = Color.White;
            ButtonHost.ForeColor = Color.Black;
            ButtonHost.Location = new Point(156, 31);
            ButtonHost.Margin = new Padding(4, 3, 4, 3);
            ButtonHost.Name = "ButtonHost";
            ButtonHost.Size = new Size(88, 27);
            ButtonHost.TabIndex = 8;
            ButtonHost.Text = "Host";
            ButtonHost.UseVisualStyleBackColor = false;
            ButtonHost.Click += ButtonOffline_Click;
            // 
            // TextName
            // 
            TextName.BackColor = Color.White;
            TextName.ForeColor = Color.Black;
            TextName.Location = new Point(14, 33);
            TextName.Margin = new Padding(4, 3, 4, 3);
            TextName.Name = "TextName";
            TextName.Size = new Size(116, 23);
            TextName.TabIndex = 10;
            TextName.Text = "Username";
            // 
            // LinkIPCopy
            // 
            LinkIPCopy.ActiveLinkColor = Color.Silver;
            LinkIPCopy.AutoSize = true;
            LinkIPCopy.ForeColor = Color.Black;
            LinkIPCopy.LinkColor = Color.White;
            LinkIPCopy.Location = new Point(14, 97);
            LinkIPCopy.Margin = new Padding(4, 0, 4, 0);
            LinkIPCopy.Name = "LinkIPCopy";
            LinkIPCopy.Size = new Size(48, 15);
            LinkIPCopy.TabIndex = 12;
            LinkIPCopy.TabStop = true;
            LinkIPCopy.Text = "Copy IP";
            LinkIPCopy.LinkClicked += LinkIPCopy_LinkClicked;
            // 
            // LinkIPShow
            // 
            LinkIPShow.ActiveLinkColor = Color.Silver;
            LinkIPShow.AutoSize = true;
            LinkIPShow.ForeColor = Color.Black;
            LinkIPShow.LinkColor = Color.White;
            LinkIPShow.Location = new Point(79, 97);
            LinkIPShow.Margin = new Padding(4, 0, 4, 0);
            LinkIPShow.Name = "LinkIPShow";
            LinkIPShow.Size = new Size(49, 15);
            LinkIPShow.TabIndex = 13;
            LinkIPShow.TabStop = true;
            LinkIPShow.Text = "Show IP";
            LinkIPShow.LinkClicked += LinkIPShow_LinkClicked;
            // 
            // Lobby
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(273, 128);
            Controls.Add(LinkIPShow);
            Controls.Add(LinkIPCopy);
            Controls.Add(TextName);
            Controls.Add(ButtonHost);
            Controls.Add(ButtonCreate);
            Controls.Add(ButtonConnect);
            Controls.Add(TextIP);
            ForeColor = Color.Black;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Lobby";
            Text = "Bull Shoot - Menu";
            FormClosing += Lobby_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TextIP;
        private Button ButtonConnect;
        private Button ButtonCreate;
        private Button ButtonHost;
        private TextBox TextName;
        private LinkLabel LinkIPCopy;
        private LinkLabel LinkIPShow;
    }
}

