using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManagerDesktopApp
{
    public partial class Connexion : Form
    {
        List<PasswordsClass> l;
        PasswordsClass p;

        public Connexion()
        {
            InitializeComponent();
            
            l = DBClass.LoadPasswordsUsingTitle("MCOTA");

            if (l.Count == 0)
                ConnectButon.Text = "Register";
            else
            {
                p = l.ElementAt(0);
                p.DecryptPassword();
                User.Name = p.AccountName;
                User.MC = p.Password;
            }
        }

        private void ConnectButon_Click(object sender, EventArgs e)
        {
            if (l.Count != 0)
            {
                bool EmptyName = string.IsNullOrEmpty(this.NameText.Texts);
                bool EmptyMC = string.IsNullOrEmpty(this.MasterCodeText.Texts);
                if (!(EmptyName || EmptyMC))
                {
                    bool name = p.AccountName.Equals(this.NameText.Texts);
                    bool mc = p.Password.Equals(this.MasterCodeText.Texts);
                    if (name && mc)
                    {
                        Home home = new Home();
                        home.Show();
                        this.Hide();
                    }
                    else
                    {
                        this.error.Text = "Invalide name or mastercode please retry";
                    }
                }
                else
                {
                    this.error.Text = "Invalide name or mastercode please retry";
                }
            }
            else
            {
                bool name = string.IsNullOrEmpty(this.NameText.Texts);
                bool mc = string.IsNullOrEmpty(this.MasterCodeText.Texts);
                if (name || mc)
                {
                    this.error.Text = "You have to enter a name and a mastercode to register please retry";
                }
                else
                {
                    PasswordsClass MasterCode = new PasswordsClass("MCOTA", this.NameText.Texts, this.MasterCodeText.Texts, "None");
                    MasterCode.EncryptPassword();
                    DBClass.AddPassword(MasterCode);
                    MessageBox.Show("Correctly Registered");
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
            }
                
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }
    }
}
