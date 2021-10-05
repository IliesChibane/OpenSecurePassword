using PasswordManagerDesktopApp.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PasswordManagerDesktopApp
{
    public partial class Passwords : Form
    {
        List<PasswordsClass> passwordList;
        public Passwords()
        {
            InitializeComponent();

            passwordList = DBClass.LoadPasswords();
            fillPaswordPanel();
        }
        private void OpenPasswordInfo(object sender, EventArgs e, PasswordsClass p)
        {
            PasswordInfo pi = new PasswordInfo();
            pi.TitleText.Texts = p.Title;
            pi.PasswordImage.Image = resizeImage(Image.FromFile(p.ImagePath), new Size(694, 239));
            pi.UEText.Texts = p.AccountName;
            pi.PaswordText.Texts = p.Password;
            Home.openChildForm(pi);
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(SearchBar.Texts))
            {
                passwordList = DBClass.LoadPasswordsUsingTitle2(SearchBar.Texts);
                fillPaswordPanel();

            }
        }

        private void fillPaswordPanel()
        {
            PasswordPanel.Controls.Clear();

            ViewCard[] vcc = new ViewCard[passwordList.Count];

            for (int i = 0; i < passwordList.Count; i++)
            {
                PasswordsClass pc = passwordList.ElementAt(i);
                pc.DecryptPassword();
                ViewCard vc = new ViewCard();
                vc.title.Text = pc.Title;
                vc.image.Image = Image.FromFile(passwordList.ElementAt(i).ImagePath);
                vc.title.Click += new EventHandler((sender, e) => OpenPasswordInfo(sender, e, pc));
                vc.image.Click += new EventHandler((sender, e) => OpenPasswordInfo(sender, e, pc));
                PasswordPanel.Controls.Add(vc);
            }
        }

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
    }
}
