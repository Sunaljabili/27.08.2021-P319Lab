using System;
using System.Collections.Generic;
using System.Text;

namespace Task3_Sunal
{
    interface IAccount
    {
        bool PasswordChecker(string password);
        void ShowInfo();
    }
}
