using System;

namespace LibraryYesNoAnagrams
{
    public class YesNoAnagrams
    {
         public string CheckAnagrams (string a, string b)
        {
            string res = GetResult(a, b);
            return res;
        }
        public string GetOnlyLetters(string str)
        {
            char[] strArray = str.Where(x => char.IsLetter(x)).ToArray();
            string result = new string(strArray);
            return result;           
        }
        private string PutStringInLowerCase(string str)
        {
            return str.ToLower();
        }
        private string SortString(string str)
        {
            char[] strArray = str.ToCharArray();
            Array.Sort(strArray);
            return new string(strArray);
        }
        private string GetResult (string str1, string str2)
        {
            str1 = GetOnlyLetters(str1);
            PutStringInLowerCase(str1);
            SortString(str1);
            str2 = GetOnlyLetters(str2);
            PutStringInLowerCase(str2);
            SortString(str2);
            string result = "";
            if (str1.Length != str2.Length)
            {
                result = "These two strings are not anagrams.";
            }
            else
            {
                if (str1.Contains(str2))
                {
                    result = "These two strings are anagrams.";
                }
            }
            return result;
        } 
    }
}