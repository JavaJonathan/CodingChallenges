using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems
{
    class ValidParenthesis
    {
        public bool IsValid(string s)
        {
            var openBraceList = new List<string>();

            for (var counter = 0; counter < s.Length; counter++)
            {
                if (s[counter] == '{' || s[counter] == '[' || s[counter] == '(')
                {
                    openBraceList.Add(s[counter].ToString());
                }
                else if (s[counter] == '}')
                {
                    if (openBraceList.Count > 0 && openBraceList[openBraceList.Count - 1] == "{")
                    {
                        openBraceList.RemoveAt(openBraceList.Count - 1);
                    }
                    else return false;
                }
                else if (s[counter] == ']')
                {
                    if (openBraceList.Count > 0 && openBraceList[openBraceList.Count - 1] == "[")
                    {
                        openBraceList.RemoveAt(openBraceList.Count - 1);
                    }
                    else return false;
                }
                else if (s[counter] == ')')
                {
                    if (openBraceList.Count > 0 && openBraceList[openBraceList.Count - 1] == "(")
                    {
                        openBraceList.RemoveAt(openBraceList.Count - 1);
                    }
                    else return false;
                }
            }

            if ( openBraceList.Count > 0 ) return false;

            return true;
        }
    }
}
