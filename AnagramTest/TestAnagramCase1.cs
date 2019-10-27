using NUnit.Framework;



namespace AnagramTest
{
 
    public class TestAnagramCase1
    {
        [Test]
        public void TestAnagramString()
        {
            Assert.AreEqual(true,  Anagram.Anagram.IsAnagram("marmy", "mmary"));
        }

        [Test]
        public void TestAnagramString2()
        {
            Assert.AreEqual(false, Anagram.Anagram.IsAnagram("Carmy", "Dmary"));
        }

    }

}
