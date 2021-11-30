using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerUC3;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string testcase1 = "I have a NULL mood";
            MoodAnalyzer obj1 = new MoodAnalyzer(testcase1);
            string actual=obj1.analyseMood();
            string expected = "Invalid Mood: NULL";
            Assert.AreEqual(actual, expected);

        }
        [TestMethod]
        public void TestMethod2()
        {
            string testcase1 = "I have a EMPTY mood";
            MoodAnalyzer obj1 = new MoodAnalyzer(testcase1);
            string actual = obj1.analyseMood();
            string expected = "Invalid Mood: EMPTY";
            Assert.AreEqual(actual, expected);

        }
    }
}
