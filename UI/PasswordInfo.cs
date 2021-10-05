using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PasswordManagerDesktopApp.UI
{
    public partial class PasswordInfo : Form
    {
        private int MD = 0;
        private string t, ue, pas;
        public PasswordInfo()
        {
            InitializeComponent();
            Confirm.Visible = false;
            CancelB.Visible = false;
            TitleText.Enabled = false;
            UEText.Enabled = false;
            PaswordText.Enabled = false;
        }

        private void Modify_Click(object sender, EventArgs e)
        {
            Confirm.Visible = true;
            CancelB.Visible = true;
            TitleText.Enabled = true;
            UEText.Enabled = true;
            PaswordText.Enabled = true;
            t = TitleText.Texts;
            ue = UEText.Texts;
            pas = PaswordText.Texts;
            MD = 1;
        }

        private void CancelB_Click(object sender, EventArgs e)
        {
            Confirm.Visible = false;
            CancelB.Visible = false;
            TitleText.Texts = t;
            UEText.Texts = ue;
            PaswordText.Texts = pas;
            TitleText.Enabled = false;
            UEText.Enabled = false;
            PaswordText.Enabled = false;
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if(MD==1)
            {
                PasswordsClass p = new PasswordsClass(TitleText.Texts, UEText.Texts, PaswordText.Texts, PasswordImage.ImageLocation);
                DBClass.ModifyPassword(p,t);
                t = TitleText.Texts;
                ue = UEText.Texts;
                pas = PaswordText.Texts;
                TitleText.Enabled = false;
                UEText.Enabled = false;
                PaswordText.Enabled = false;
                MessageBox.Show("Password Information Updated Sucessfully");
            }
            else
            {
                DBClass.DeletePassword(TitleText.Texts);
                MessageBox.Show("Password Deleted Sucessfully");
                Home.openChildForm(new Passwords());
            }

            Confirm.Visible = false;
            CancelB.Visible = false;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Confirm.Visible = true;
            CancelB.Visible = true;
            MD = 0;
        }

    }
}
