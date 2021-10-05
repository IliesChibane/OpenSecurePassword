using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PasswordManagerDesktopApp
{
    public partial class AddPassword : Form
    {
        String dir = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
        String ImagePath = "";
        public AddPassword()
        {
            InitializeComponent();
            fillComBox();
        }

        public void fillComBox()
        {
            LogoName.Items.Add("Deezer");
            LogoName.Items.Add("Facebook");
            LogoName.Items.Add("Google");
            LogoName.Items.Add("HackerRank");
            LogoName.Items.Add("Instagram");
            LogoName.Items.Add("Linkedin");
            LogoName.Items.Add("Netflix");
            LogoName.Items.Add("Outllook");
            LogoName.Items.Add("ProtonMail");
            LogoName.Items.Add("Snapchat");
            LogoName.Items.Add("Spotify");
            LogoName.Items.Add("Tiktok");
            LogoName.Items.Add("Twitch");
            LogoName.Items.Add("Twitter");
            LogoName.Items.Add("Yahoo");
            LogoName.Items.Add("Other");
        }

        private void LogoName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (LogoName.SelectedItem.ToString())
            {
                case "Deezer":
                    Logo.Image = LogoList.Images[0];
                    ImagePath = dir.Substring(0, dir.Length - 3) + @"logos/Deezer.png";
                    break;
                case "Facebook":
                    Logo.Image = LogoList.Images[1];
                    ImagePath = dir.Substring(0, dir.Length - 3) + @"logos/Facebook.png";
                    break;
                case "Google":
                    Logo.Image = LogoList.Images[2];
                    ImagePath = dir.Substring(0, dir.Length - 3) + @"logos/Google.png";
                    break;
                case "HackerRank":
                    Logo.Image = LogoList.Images[3];
                    ImagePath = dir.Substring(0, dir.Length - 3) + @"logos/HackerRank.png";
                    break;
                case "Instagram":
                    Logo.Image = LogoList.Images[4];
                    ImagePath = dir.Substring(0, dir.Length - 3) + @"logos/Instagram.png";
                    break;
                case "Linkedin":
                    Logo.Image = LogoList.Images[5];
                    ImagePath = dir.Substring(0, dir.Length - 3) + @"logos/Linkedin.png";
                    break;
                case "Netflix":
                    Logo.Image = LogoList.Images[6];
                    ImagePath = dir.Substring(0, dir.Length - 3) + @"logos/Netflix.png";
                    break;
                case "Outllook":
                    Logo.Image = LogoList.Images[7];
                    ImagePath = dir.Substring(0, dir.Length - 3) + @"logos/Outllook.png";
                    break;
                case "ProtonMail":
                    Logo.Image = LogoList.Images[8];
                    ImagePath = dir.Substring(0, dir.Length - 3) + @"logos/ProtonMail.png";
                    break;
                case "Snapchat":
                    Logo.Image = LogoList.Images[9];
                    ImagePath = dir.Substring(0, dir.Length - 3) + @"logos/Snapchat.png";
                    break;
                case "Spotify":
                    Logo.Image = LogoList.Images[10];
                    ImagePath = dir.Substring(0, dir.Length - 3) + @"logos/Spotify.png";
                    break;
                case "Tiktok":
                    Logo.Image = LogoList.Images[11];
                    ImagePath = dir.Substring(0, dir.Length - 3) + @"logos/Tiktok.png";
                    break;
                case "Twitch":
                    Logo.Image = LogoList.Images[12];
                    ImagePath = dir.Substring(0, dir.Length - 3) + @"logos/Twitch.png";
                    break;
                case "Twitter":
                    Logo.Image = LogoList.Images[13];
                    ImagePath = dir.Substring(0, dir.Length - 3) + @"logos/Twitter.png";
                    break;
                case "Yahoo":
                    Logo.Image = LogoList.Images[14];
                    ImagePath = dir.Substring(0, dir.Length - 3) + @"logos/Yahoo.png";
                    break;
                case "Other":
                    AddImage(); 
                    break;
            }
        }

        private void AddImage()
        {
            OpenFileDialog fileOpen = new OpenFileDialog();
            fileOpen.Title = "Open Image file";
            fileOpen.Filter = "JPG Files (*.jpg)| *.jpg";

            if (fileOpen.ShowDialog() == DialogResult.OK)
            {
                LogoList.Images.Add(Image.FromFile(fileOpen.FileName));
                Logo.Image = LogoList.Images[LogoList.Images.Count-1];
                String fn = fileOpen.FileName;
                String sf = dir.Substring(0, dir.Length - 3) + @"logos";
                String nfn = @"/logo number"+ LogoList.Images.Count+".png";
                ImagePath = sf + nfn;
                File.Copy(fn, ImagePath, false);
            }
        }

        private void AddPasswordButon_Click(object sender, EventArgs e)
        {
            if (!AllFieldsNotEmpty())
            {
                PasswordsClass passwordInfo = new PasswordsClass(this.TitleText.Texts, this.UEText.Texts, this.PaswordText.Texts, ImagePath);
                passwordInfo.EncryptPassword();
                DBClass.AddPassword(passwordInfo);
                MessageBox.Show("Password Added Succesfully");
            }
        }

        private bool AllFieldsNotEmpty()
        {
            return string.IsNullOrEmpty(this.TitleText.Texts) || string.IsNullOrEmpty(this.UEText.Texts) || string.IsNullOrEmpty(this.PaswordText.Texts) || string.IsNullOrEmpty(ImagePath);
        }

        private void EmptyFields()
        {
            this.TitleText.Texts = "";
            this.UEText.Texts = "";
            this.PaswordText.Texts = "";
            this.ImagePath = "";
        }
    }
}
