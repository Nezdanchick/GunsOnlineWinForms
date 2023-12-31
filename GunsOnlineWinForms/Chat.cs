﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunsOnlineWinForms
{
    public partial class Chat : CustomForm
    {
        public string ChatText { get; private set; } = "";
        public Chat() : base(true, false, false)
        {
            InitializeComponent();
            SetDesktopLocation(Screen.PrimaryScreen.WorkingArea.Width,
                Screen.PrimaryScreen.WorkingArea.Height);

            // Controls setup
            ButtonSend.DisableSelect();
            TextBox.Clear();
            TextBox.Select();
        }

        public void ChatAdd(string text)
        {
            text = text.Trim();
            if (text.Length == 0) return;
            string add = $"You: {text}";
            ListBox.Items.Add(add);
            ChatText += add + "\n";
            TextBox.Clear();
            if (ListBox.Items.Count >= 15)
            {
                ListBox.Items.RemoveAt(0);
                ChatText = ChatText[(ChatText.IndexOf('\n') + 1)..];
            }
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            ChatAdd(TextBox.Text);
            Hide();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ChatAdd(TextBox.Text);
                Hide();
            }
        }
    }
}
