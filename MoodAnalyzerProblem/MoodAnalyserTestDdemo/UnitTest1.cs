using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;

namespace MoodAnalyserTestDdemo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1GetMood()
        {
            MoodAnalyzer obj1 = new MoodAnalyzer();

            string testcase1 = "I am in Sad mood";
           
            string expectedTestCase1 = "SAD";
           
            string actual = obj1.analyseMood(testcase1);
            Assert.AreEqual(expectedTestCase1, actual);


        }

        [TestMethod]
        public void TestMethod2GetMood()
        {
            MoodAnalyzer obj1 = new MoodAnalyzer();

           
            string testcase2 = "I am in Any mood";
            
            string expectedTestCase2 = "HAPPY";
            string actual = obj1.analyseMood(testcase2);
            Assert.AreEqual(expectedTestCase2, actual);


        }








        //public void GetNameTest()
        // {
        //     Employee employee = new Employee();
        //     string firstname = "Bridge";
        //     string lastname = "labz";
        //     string expected = "Bridge labz";
        //     string actual;
        //     actual = employee.GetName(firstname, lastname);
        //     Assert.AreEqual(expected, actual);
        // }




    }
}
