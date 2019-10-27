using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PalindromeProject
{
    public class Palindrome
    {
        public Palindrome()
        {

        }

        public static bool IsPalindrome(string  text)
        {
            text = text.ToLower().Trim().Replace(" ", string.Empty);
            text = Regex.Replace(text, "[^a-zA-Z0-9]", "");
            var midIndex = text.Length / 2;
            var textFirstHalf = text.Substring(0, midIndex);
            var textSecondHalf = text.Substring(midIndex +1);
            var textCharArray = textSecondHalf.ToCharArray();
            Array.Reverse(textCharArray);
            textSecondHalf = new String(textCharArray);

            return textFirstHalf == textSecondHalf;

           
        }
    }
}
