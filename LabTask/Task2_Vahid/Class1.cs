using System;
using System.Collections.Generic;
using System.Text;

namespace Task2_Vahid
{
    static class Class1
    {
        public static void Change(this string str)
        {
            string[] badwords = { "tehqir1", "tehqir2" };
            for (int i = 0; i < badwords.Length; i++)
            {
                str = str.Replace(badwords[i], "oops");
            }
            Console.WriteLine(str);
        }
    }
}
