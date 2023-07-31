﻿namespace GunsOnlineWinForms
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.ButtonMinimize = new System.Windows.Forms.Button();
            this.ButtonMaximize = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.TextChat = new System.Windows.Forms.Label();
            this.ChatFade = new System.Windows.Forms.Timer(this.components);
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.PanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Black;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(800, 450);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.Gray;
            this.PanelTop.Controls.Add(this.ButtonMinimize);
            this.PanelTop.Controls.Add(this.ButtonMaximize);
            this.PanelTop.Controls.Add(this.ButtonExit);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(800, 22);
            this.PanelTop.TabIndex = 1;
            this.PanelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseMove);
            // 
            // ButtonMinimize
            // 
            this.ButtonMinimize.BackColor = System.Drawing.Color.White;
            this.ButtonMinimize.ForeColor = System.Drawing.Color.Black;
            this.ButtonMinimize.Location = new System.Drawing.Point(31, 0);
            this.ButtonMinimize.Name = "ButtonMinimize";
            this.ButtonMinimize.Size = new System.Drawing.Size(22, 22);
            this.ButtonMinimize.TabIndex = 4;
            this.ButtonMinimize.Text = "_";
            this.ButtonMinimize.UseVisualStyleBackColor = false;
            this.ButtonMinimize.Click += new System.EventHandler(this.ButtonMinimize_Click);
            // 
            // ButtonMaximize
            // 
            this.ButtonMaximize.BackColor = System.Drawing.Color.White;
            this.ButtonMaximize.ForeColor = System.Drawing.Color.Black;
            this.ButtonMaximize.Location = new System.Drawing.Point(59, 0);
            this.ButtonMaximize.Name = "ButtonMaximize";
            this.ButtonMaximize.Size = new System.Drawing.Size(22, 22);
            this.ButtonMaximize.TabIndex = 3;
            this.ButtonMaximize.Text = "+";
            this.ButtonMaximize.UseVisualStyleBackColor = false;
            this.ButtonMaximize.Click += new System.EventHandler(this.ButtonMaximize_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.Color.White;
            this.ButtonExit.ForeColor = System.Drawing.Color.Black;
            this.ButtonExit.Location = new System.Drawing.Point(3, 0);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(22, 22);
            this.ButtonExit.TabIndex = 2;
            this.ButtonExit.Text = "X";
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // TextChat
            // 
            this.TextChat.AutoSize = true;
            this.TextChat.BackColor = System.Drawing.Color.Black;
            this.TextChat.ForeColor = System.Drawing.Color.White;
            this.TextChat.Location = new System.Drawing.Point(24, 50);
            this.TextChat.Name = "TextChat";
            this.TextChat.Size = new System.Drawing.Size(29, 13);
            this.TextChat.TabIndex = 2;
            this.TextChat.Text = "Chat";
            this.TextChat.TextChanged += new System.EventHandler(this.TextChat_TextChanged);
            // 
            // ChatFade
            // 
            this.ChatFade.Enabled = true;
            this.ChatFade.Interval = 15000;
            this.ChatFade.Tick += new System.EventHandler(this.ChatFade_Tick);
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextChat);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.pictureBox);
            this.Name = "MainForm";
            this.Text = "Bull Shoot";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.PanelTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonMinimize;
        private System.Windows.Forms.Button ButtonMaximize;
        private System.Windows.Forms.Label TextChat;
        private System.Windows.Forms.Timer ChatFade;
        private System.Windows.Forms.Timer GameTimer;
    }
}

