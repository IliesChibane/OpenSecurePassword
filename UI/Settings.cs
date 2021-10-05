using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PasswordManagerDesktopApp
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DBClass.DeleteAllPassword();
            MessageBox.Show("All Passwords Deleted Sucessfully");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            //this.ChangeMCPanel.Visible = !this.ChangeMCPanel.Visible;
        }

        private void ChangeNameButton_Click(object sender, EventArgs e)
        {
            //this.ChangeNamePanel.Visible = !this.ChangeNamePanel.Visible;
        }

        private void ChangeNameB_Click(object sender, EventArgs e)
        {
            bool name = User.Name.Equals(this.OldName.Texts);
            bool mc = User.MC.Equals(this.MasterCode.Texts);
            if (name && mc)
            {
                PasswordsClass MasterCode = new PasswordsClass("MCOTA", this.NewName.Texts, this.MasterCode.Texts, "None");
                DBClass.ModifyPassword(MasterCode, "MCOTA");
                User.Name = this.NewName.Texts;
                MessageBox.Show("Name changed succesfully");
            }
            
        }

        private void ChangeMCButton_Click(object sender, EventArgs e)
        {
            bool mc = User.MC.Equals(this.OldMc.Texts);
            if (mc)
            {
                PasswordsClass MasterCode = new PasswordsClass("MCOTA", User.Name, this.NewMC.Texts, "None");
                MasterCode.EncryptPassword();
                DBClass.ModifyPassword(MasterCode, "MCOTA");
                User.MC = this.NewMC.Texts;
                MessageBox.Show("MasterCode changed succesfully");
            }

        }

        private void OldNameClick(object sender, EventArgs e)
        {
            if (OldName.Texts.Equals("Old Name"))
                OldName.Texts = "";
        }

        private void NewNameClick(object sender, EventArgs e)
        {
            if (NewName.Texts.Equals("New Name"))
                NewName.Texts = "";
        }

        private void MasterCodeClick(object sender, EventArgs e)
        {
            if (MasterCode.Texts.Equals("MasterCode"))
                MasterCode.Texts = "";
        }

        private void NewMCClick(object sender, EventArgs e)
        {
            if (NewMC.Texts.Equals("New MaterCode"))
                NewMC.Texts = "";
        }

        private void OldMcClick(object sender, EventArgs e)
        {
            if (OldMc.Texts.Equals("Old MaterCode"))
                OldMc.Texts = "";
        }



    }
}
