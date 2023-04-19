using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems
{
    class ValidPalindrone
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(""));
        }
        public static bool IsPalindrome(string s)
        {
            /*Original Solution*/

            //var formattedString = "";
            //for (var counter = 0; counter < s.Length; counter++)
            //{
            //    if (Char.IsLetterOrDigit(s[counter]))
            //    {
            //        formattedString += s[counter];
            //    }
            //}

            //formattedString = formattedString.ToLower();

            //var reverseCounter = formattedString.Length - 1;

            //for (var counter = 0; counter < formattedString.Length; counter++)
            //{
            //    if (formattedString[counter] != formattedString[reverseCounter]) return false;
            //    reverseCounter--;
            //}

            //return true;

            /*Optimized Implementation*/

            var forwardCounter = 0;
            var reverseCounter = s.Length - 1;
            var forwardComapreValue = "";
            var reverseCompareValue = "";

            while(true)
            { 
                while(forwardCounter <= s.Length - 1)
                {
                    if (Char.IsLetterOrDigit(s[forwardCounter]))
                    {
                        forwardComapreValue = s[forwardCounter].ToString();
                        forwardCounter++;
                        break;
                    }
                    forwardCounter++;
                }

                while(reverseCounter >= 0)
                {
                    if (Char.IsLetterOrDigit(s[reverseCounter]))
                    {
                        reverseCompareValue = s[reverseCounter].ToString();
                        reverseCounter--;
                        break;
                    }
                    reverseCounter--;
                }

                if (reverseCompareValue.ToLower() != forwardComapreValue.ToLower()) return false;
                if (reverseCounter <= 0 || forwardCounter >= (s.Length - 1)) break;
            }

            return true;
        }
    }
}
