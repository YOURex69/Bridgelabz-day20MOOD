using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserUC1refactor;
namespace TesterUC2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string testcase1 = "My mood is NULL";
            MoodAnalyzer obj1 = new MoodAnalyzer(testcase1);
            string actual=obj1.analyseMood();
            string expected = "HAPPY";
            Assert.AreEqual(actual, expected);
            
        }
    }
}
