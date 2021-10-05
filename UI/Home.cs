using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PasswordManagerDesktopApp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private static Form Activeform = null;
        public static void openChildForm(Form child)
        {
            if (child != null)
            {
                Activeform = child;
                child.TopLevel = false;
                child.FormBorderStyle = FormBorderStyle.None;
                child.Dock = DockStyle.Fill;
                MainPanel.Controls.Add(child);
                MainPanel.Tag = child;
                child.BringToFront();
                child.Show();
            }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            openChildForm(new Passwords());
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            openChildForm(new AddPassword());
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            openChildForm(new Settings());
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            if (Application.MessageLoop)
            {
                // WinForms app
                Application.Exit();
            }
            else
            {
                // Console app
                Environment.Exit(1);
            }
        }
    }
}
