using System;
using System.Collections.Generic;
using System.Text; 

namespace PasswordManagerDesktopApp
{
    class EncryptAndDecrypt
    {
        public static char Encrypt(char ch, int length, int z)
        {
            int ascii = Convert.ToInt32(ch) + length;
            if ((ascii > z)&&(z != Convert.ToInt32('9')))
                ascii = ascii - 26;
            else if ((ascii > z) && (z == Convert.ToInt32('9')))
                ascii = ascii - 10;

            return Convert.ToChar(Convert.ToInt32(ascii));
        }

        public static String Encryption(String str)
        {
            String encrypted = "";
            String rts = "";
            for(int i = (str.Length-1); i>=0; i--)
            {
                rts += str[i];
            }
            str = rts;
            int Length = str.Length;

            for(int i = 0; i<Length; i++)
            {
                bool ba = Convert.ToInt32(str[i]) >= Convert.ToInt32('a');
                bool bz = Convert.ToInt32(str[i]) <= Convert.ToInt32('z');
                bool bA = Convert.ToInt32(str[i]) >= Convert.ToInt32('A');
                bool bZ = Convert.ToInt32(str[i]) <= Convert.ToInt32('Z');
                bool b0 = Convert.ToInt32(str[i]) >= Convert.ToInt32('0');
                bool b9 = Convert.ToInt32(str[i]) <= Convert.ToInt32('9');

                if (ba && bz)
                    encrypted += Encrypt(str[i],
                                         Length,
                                         Convert.ToInt32('z'));
                else if (bA && bZ)
                    encrypted += Encrypt(str[i],
                                         Length,
                                         Convert.ToInt32('Z'));
                else if (b0 && b9)
                    encrypted += Encrypt(str[i],
                                         Length,
                                         Convert.ToInt32('9'));
                else
                    encrypted += str[i];
            }

            return encrypted;
        }

        public static char Decrypt(char ch, int length, int a)
        {
            int ascii = Convert.ToInt32(ch) - length;
            if ((ascii < a) && (a != Convert.ToInt32('0')))
                ascii = ascii + 26;
            else if ((ascii < a) && (a == Convert.ToInt32('0')))
                ascii = ascii + 10;

            return Convert.ToChar(Convert.ToInt32(ascii));
        }

        public static String Decryption(String str)
        {
            String decrypted = "";
            String rts = "";
            for (int i = (str.Length - 1); i >= 0; i--)
            {
                rts += str[i];
            }
            str = rts;
            int Length = str.Length;

            for (int i = 0; i < Length; i++)
            {
                bool ba = Convert.ToInt32(str[i]) >= Convert.ToInt32('a');
                bool bz = Convert.ToInt32(str[i]) <= Convert.ToInt32('z');
                bool bA = Convert.ToInt32(str[i]) >= Convert.ToInt32('A');
                bool bZ = Convert.ToInt32(str[i]) <= Convert.ToInt32('Z');
                bool b0 = Convert.ToInt32(str[i]) >= Convert.ToInt32('0');
                bool b9 = Convert.ToInt32(str[i]) <= Convert.ToInt32('9');

                if (ba && bz)
                    decrypted += Decrypt(str[i],
                                         Length,
                                         Convert.ToInt32('a'));
                else if (bA && bZ)
                    decrypted += Decrypt(str[i],
                                         Length,
                                         Convert.ToInt32('A'));
                else if (b0 && b9)
                    decrypted += Decrypt(str[i],
                                         Length,
                                         Convert.ToInt32('0'));
                else
                    decrypted += str[i];
            }

            return decrypted;
        }
    }
}
