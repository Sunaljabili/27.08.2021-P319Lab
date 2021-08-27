using System;
using System.Collections.Generic;
using System.Text;

namespace Task2_MM
{
    static class Class1
    {
        public static string SecretBannedWords(this string str)
        {
            string[] banned = { "tehqir1", "tehqir2" };
            string[] sentence = str.Split(" ");
            for (int i = 0; i < banned.Length; i++)
            {
                for (int j = 0; j < sentence.Length; j++)
                {
                    if(sentence[j] == banned[i])
                    {
                        sentence[j] = "Oops";
                    }

                }
            }

            return String.Join(" ", sentence);
        }
    }
}
