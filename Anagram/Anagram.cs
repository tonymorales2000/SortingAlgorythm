using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Anagram
{
    public class Anagram
    {
        public Anagram()
        {

        }
        public static bool IsAnagram(string text1, string text2)
        {
            if(text1.Length != text2.Length)
            {
                return false;
            }

           
            text1 = text1.ToLower().Trim();
            text2 = text2.ToLower().Trim();
            Hashtable ht1 = new Hashtable() ;
            Hashtable ht2 = new Hashtable() ;
                       
            char[] textArray1 = text1.ToCharArray();

            
            foreach(char c in textArray1)
            {
                char.GetNumericValue(c);
                ht1.Add(c, c);
            }
            char[] textArray2 = text2.ToCharArray();
            
            foreach (char c in textArray2)
            {
                ht2.Add(c, c);
            }

            if (ht1.Values .Equals(ht2.Values))
            {
                return true;
            }


            Array.Sort(textArray1);
            Array.Sort(textArray2);
            var sortedText1 = new String(textArray1);
            var sortedText2 = new String(textArray2);



            return sortedText1 == sortedText2;

        }
    }
}
