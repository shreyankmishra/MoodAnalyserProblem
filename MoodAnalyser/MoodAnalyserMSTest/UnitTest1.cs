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

        [TestMethod]
        public void TestMethodGivenNullThrowMoodAnalysisException()
        {
            try
            {
                //Arrange
                string message = null;
                MoodAnalyse moodAnalyser = new MoodAnalyse(message);
                //Act
                string result = moodAnalyser.AnalyseMood();
            }
            catch (MoodAnalysisException ex)
            {
                //Assert
                Assert.AreEqual("Mood should not be Null.", ex.Message);
            }
        }
        [TestMethod]
        public void TestMethodGivenEmptyThrowMoodAnalysisException()
        {
            try
            {
                //Arrange
                string message = "";
                MoodAnalyse moodAnalyser = new MoodAnalyse(message);
                //Act
                string result = moodAnalyser.AnalyseMood();
            }
            catch (MoodAnalysisException ex)
            {
                //Assert
                Assert.AreEqual("Mood should not be Empty.", ex.Message);
            }
        }
        [TestMethod]
        public void TestMethodGivenMoodAnalyserClassNameShouldReturnMoodAnalyserObject()
        {
            string className = "MoodAnalyser.MoodAnalyse";
            string constructorName = "MoodAnalyse";
            MoodAnalyse expected = new MoodAnalyse();
            object resultObj = MoodAnalyserFactory.CreateMoodAnalyserObject(className, constructorName);
            expected.Equals(resultObj);
        }
        [TestMethod]
        public void TestMethodGivenImproperClassNameShouldThrowMoodAnalysisExceptionIndicatingNoSuchClass()
        {
            try
            {
                //Arrange
                string className = "WrongNamespace.MoodAnalyse";
                string constructorName = "MoodAnalyse";
                //Act
                object resultObj = MoodAnalyserFactory.CreateMoodAnalyserObject(className, constructorName);
            }
            catch (MoodAnalysisException e)
            {
                //Assert
                Assert.AreEqual("class not found", e.Message);
            }
        }
        [TestMethod]
        public void TestMethodGivenImproperConstructorNameShouldThrowMoodAnalysisExceptionIndicatingNoSuchConstructor()
        {
            try
            {
                //Arrange
                string className = "MoodAnalyser.MoodAnalyse";
                string constructorName = "WrongConstructorName";
                //Act
                object resultObj = MoodAnalyserFactory.CreateMoodAnalyserObject(className, constructorName);
            }
            catch (MoodAnalysisException e)
            {
                //Assert
                Assert.AreEqual("constructor not found", e.Message);
            }
        }
    }
}
    


