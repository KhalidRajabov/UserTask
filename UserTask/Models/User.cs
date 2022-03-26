using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_AccesModifiers_Encapsulation_Readonly.Models
{
    internal class User
    {
        private string _username;
        private int _age;
        private string _password;
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                    _username = value;
                
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                    _age = value;   
            }
        }
        public void UserInfo()
        {
            Console.WriteLine($"You are now named === {Username} === as a user \n" +
                $"Your age is set to  === {Age} === \n" +
                $"Your password is set to === {Password} ===");
        }
    }
}
