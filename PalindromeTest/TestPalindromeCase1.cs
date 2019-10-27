using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeTest
{
    public class TestPalindromeCase1
    {
        [Test]
        public void TestCase1()
        {
           string text = "never";
           Assert.IsFalse(PalindromeProject.Palindrome.IsPalindrome(text));
            text = "Kayak";
            Assert.IsTrue(PalindromeProject.Palindrome.IsPalindrome(text));
            text = "Red rum, sir, is murder";
            Assert.IsTrue(PalindromeProject.Palindrome.IsPalindrome(text));
        }
    }
}
