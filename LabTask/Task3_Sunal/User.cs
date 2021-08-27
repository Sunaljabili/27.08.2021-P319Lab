using System;
using System.Collections.Generic;
using System.Text;

namespace Task3_Sunal
{
    class User : IAccount
    {
        public User(string email,string password)
        {
            Email = email;
            Password = password;
        }
        public string Fullname;
        public string Email;
        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (PasswordChecker(value))
                {
                    _password = value;
                    Console.WriteLine("Successfully");
                }
                else
                {
                    Console.WriteLine("Duzgun Format Daxil edin");
                }
            }
        }
        public bool PasswordChecker(string password)
        {
            bool isDigit = false;
            bool isLower = false;
            bool isUpper = false;
            if (password.Length >= 8)
            {
                foreach (char item in password)
                {
                    if (char.IsDigit(item))
                    {
                        isDigit = true;
                    }
                    else if (char.IsLower(item))
                    {
                        isLower = true;
                    }
                    else if (char.IsUpper(item))
                    {
                        isUpper = true;
                    }
                }
                if(isDigit && isLower && isUpper)
                {
                    return true;
                }
            }
            return false;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{Email} {Fullname}");
        }
    }
}
