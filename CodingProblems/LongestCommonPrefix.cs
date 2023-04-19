using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems
{
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 1) return strs[0];

            var input = new string[] { "flower", "flow", "flight" };
            var longestCommonPrefix = "";
            char? latestLetter = null;
            int checkIndex = 0;

            while (true)
            {
                for (var counter = 0; counter < strs.Length; counter++)
                {
                    if (counter == 0 && strs[counter].Length > checkIndex)
                    {
                        latestLetter = strs[counter][checkIndex];
                    }
                    else if (strs[counter].Length > checkIndex)
                    {
                        if (strs[counter][checkIndex] == latestLetter)
                        {
                            if ((counter + 1) == strs.Length) longestCommonPrefix += strs[counter][checkIndex];
                        }
                        else { return longestCommonPrefix; }
                    }
                    else return longestCommonPrefix;
                }

                if (checkIndex == (strs[0].Length - 1)) break;

                checkIndex++;
            }

            return longestCommonPrefix;
        }
    }
}
