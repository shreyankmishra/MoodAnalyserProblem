using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace MoodAnalyserMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodSadMood()
        {   //Arrange
            string message = "I am in Sad Mood";
            MoodAnalyse mood = new MoodAnalyse(message);
            //Act
            string result = mood.AnalyseMood();
            //Assert
            Assert.AreEqual(result, "SAD");
        }

        [TestMethod]
        public void TestMethodAnyMood()
        {
            //Arrange
            string message = "I am in Any Mood";
            MoodAnalyse mood = new MoodAnalyse(message);
            //Act
            string result = mood.AnalyseMood();
            //Assert
            Assert.AreEqual(result, "HAPPY");
        }
    }
}
