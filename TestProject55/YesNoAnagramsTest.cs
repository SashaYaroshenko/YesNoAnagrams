using LibraryYesNoAnagrams;

namespace TestProject55
{
    [TestFixture]
    public class Tests
    {
        
        [Test]
        [TestCase ("rail safety", "fairy tales", "These two strings are anagrams.")]
        [TestCase ("listen", "silent", "These two strings are anagrams.")]
        [TestCase ("Hello World", "Goodbye World", "These two strings are not anagrams.")]

        public void IsQuickTest (string testString, string testString2, string expectedResult)
        {
            Assert.AreEqual(expectedResult, testString, testString2);
        }
    }
}