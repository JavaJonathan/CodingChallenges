using System;

namespace CodingProblems
{
    class Program
    {
        static void PalindroneNumber(string[] args)
        {
            var testString = 121;
            var testString2 = testString.ToString();
            for (var counter = 0; counter < testString2.Length; counter++) {
                if (!testString2[counter].Equals(testString2[testString2.Length - ( counter + 1 )]))
                {
                    //return false;
                }
            }
        }
    }
}
