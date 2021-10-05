using System;
using System.Configuration;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using Dapper;
using System.Linq;

namespace PasswordManagerDesktopApp
{
    class DBClass
    {
        private static String LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static List<PasswordsClass> LoadPasswords()
        {
            using(IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var passwordlist = cnn.Query<PasswordsClass>("select * from Passwords where Title != 'MCOTA'",new DynamicParameters());
                return passwordlist.ToList();
            }
        }

        public static List<PasswordsClass> LoadPasswordsUsingTitle(string Title)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var passwordlist = cnn.Query<PasswordsClass>("select * from Passwords where Title = '"+Title+"'", new DynamicParameters());
                return passwordlist.ToList();
            }
        }

        public static List<PasswordsClass> LoadPasswordsUsingTitle2(string Title)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var passwordlist = cnn.Query<PasswordsClass>("select * from Passwords where Title like '%" + Title + "%' AND Title != 'MCOTA' ", new DynamicParameters());
                return passwordlist.ToList();
            }
        }

        public static void AddPassword(PasswordsClass password)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Passwords values (@Title, @AccountName, @Password, @ImagePath)", new  { Title = password.Title, AccountName = password.AccountName, Password = password.Password, ImagePath = password.ImagePath});
            }
        }

        public static void DeletePassword(String title)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("delete from Passwords where Title = @Title", new { Title = title });
            }
        }

        public static void DeleteAllPassword()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("delete from Passwords where Title != 'MCOTA'");
            }
        }

        public static void ModifyPassword(PasswordsClass password,string t)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE Passwords SET Title = @Title, AccountName = @AccountName, Password = @Password WHERE Title = @OGT;", new { Title = password.Title, AccountName = password.AccountName, Password = password.Password, OGT = t });
            }
        }
    }
}
