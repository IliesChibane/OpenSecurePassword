using System;
using System.Collections.Generic;
using System.Text;


namespace PasswordManagerDesktopApp
{
    class PasswordsClass
    {
        public String Title { get; set; }
        public String AccountName { get; set; }
        public String Password { get; set; }
        public String ImagePath { get; set; }

        public PasswordsClass(string title, string accountName, string password, string imagePath)
        {
            Title = title;
            AccountName = accountName;
            Password = password;
            ImagePath = imagePath;
        }

        public void EncryptPassword()
        {
            this.Password = EncryptAndDecrypt.Encryption(this.Password);
        }

        public void DecryptPassword()
        {
            this.Password = EncryptAndDecrypt.Decryption(this.Password);
        }
    }
}
