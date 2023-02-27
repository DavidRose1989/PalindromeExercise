using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {

        public static bool IsAPalindrome(string word)
        {

            string wordReverse = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                wordReverse += word[i];
            }

            if (word == wordReverse)
            {
                return true;

            }
            else
            {
                return false;
            }




        }

    }
}
