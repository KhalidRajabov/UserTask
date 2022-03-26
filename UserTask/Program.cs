using System;
using System.Reflection;
using CSharp_AccesModifiers_Encapsulation_Readonly.Models;
namespace CSharp_AccesModifiers_Encapsulation_Readonly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = GetInputStr("Enter your username: ", 5, 15);
            int userage = GetInputInt("Enter your age: ", 1, 120);
            string userpass = PassCheck("Enter your password: ", 8, 15, 0);
            User user1 = new User()
            {
                Username = username,
                Age = userage,
                Password = userpass
            };
            user1.UserInfo();
        }
        static string PassCheck(string name, int min, int max, int pas)
        {
            string input;
            int word = pas;
            do
            {
                Console.WriteLine(name);
                input = Console.ReadLine();
                char[] passw = input.ToCharArray();
                for (int i = 0; i < passw.Length; i++)
                {
                    if (char.IsNumber(passw[i]) == true)
                    {
                        for (int j = 0; j < passw.Length; j++)
                        {
                            if (char.IsUpper(passw[j]) == true)
                            {
                                word = 2;
                            }
                        }
                    }
                }
                if (word != 2)
                {
                    Console.WriteLine("Password must contain at least an uppercase and a number");
                }
            }
            while (word != 2 || input.Length < min ||  input.Length > max );
            return input;
        }
        static String GetInputStr(string name, int min, int max)
        {
            string input;
            do
            {
                Console.Write(name);
                input = Console.ReadLine();
                if (input.Length<min || input.Length > max)
                {
                    Console.WriteLine("The length  of username must be between 5 and 15");
                }
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
                if (min> input || max<input)
                {
                    Console.WriteLine("Age must not be less than 1, and more than 120");
                }
            } while (input < min || input > max);
            return input;
        }
    }
}