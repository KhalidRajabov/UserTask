using System;
using System.Reflection;
using CSharp_AccesModifiers_Encapsulation_Readonly.Models;

namespace CSharp_AccesModifiers_Encapsulation_Readonly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region test
            /*            User pass = new User();
                        typeof(User).GetField("_password", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(pass, "dhjakshdkahkd");
                        var _password  = typeof(User).GetField("_password", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(pass);

                        Console.WriteLine(_password);
            */
            #endregion
            string username = GetInputStr("Enter your username: ", 5, 15);


            int userage = GetInputInt("Enter your age: ", 1, 120);


            string userpass = PassCheck("Enter your password: ", 8, 15);
            User user1 = new User()
            {
                Username = username,
                Age = userage,
                Password = userpass

            };

            user1.UserInfo();




        }
        static string PassCheck(string name, int min, int max)
        {
            string input;
            int k = 0;
            int k1 = 0;
            int k2 = 0;

            do
            {

                Console.WriteLine(name);
                input = Console.ReadLine();
                char[] passw = input.ToCharArray();
                for (int i = 0; i < passw.Length; i++)
                {
                    if (Char.IsNumber(passw[i]) == true)
                    {
                        k1 = 1;
                    }
                    if (char.IsUpper(passw[i]) == true)
                    {
                        k2 = 1;
                    }
                }

                k = k1 + k2;
                return k;
            }

            while (input.Length < min && input.Length > max && k != 2);
            return input;
        }

        static String GetInputStr(string name, int min, int max)
        {
            string input;
            do
            {
                Console.Write(name);
                input = Console.ReadLine();

            } while (input.Length < min || input.Length > max);
            return input;
        }

        static int GetInputInt(string name, int min = int.MinValue, int max = int.MaxValue)
        {
            int input;
            do
            {
                Console.Write(name);
                input = Convert.ToInt32(Console.ReadLine());

            } while (input < min || input > max);
            return input;
        }

    }
}

