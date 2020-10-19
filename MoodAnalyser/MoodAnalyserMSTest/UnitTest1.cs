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
        [TestMethod]
        public void TestMethodGivenMoodAnalyserClassNameShouldReturnMoodAnalyserObjectParameterisedConstructor()
        {

            //Arrange
            string className = "MoodAnalyser.MoodAnalyse";
            string constructorName = "MoodAnalyse";
            MoodAnalyse expectedObj = new MoodAnalyse("HAPPY");
            //Act
            object resultObj = MoodAnalyserFactory.CreateMoodAnalyserObjectParameterisedConstructor(className, constructorName, "HAPPY");
            //Assert
            expectedObj.Equals(resultObj);
        }

        [TestMethod]
        public void TestMethodGivenImproperClassNameShouldThrowMoodAnalysisExceptionParameterisedConstructor()
        {
            try
            {
                //Arrange
                string className = "WrongNameSpace.MoodAnalyse";
                string constructorName = "MoodAnalyse";
                MoodAnalyse expectedObj = new MoodAnalyse("HAPPY");
                //Act
                object resultObj = MoodAnalyserFactory.CreateMoodAnalyserObjectParameterisedConstructor(className, constructorName, "HAPPY");
            }
            catch (MoodAnalysisException e)
            {
                //Assert
                Assert.AreEqual("class not found", e.Message);
            }
        }
        [TestMethod]
        public void TestMethodGivenImproperConstructorNameShouldThrowMoodAnalysisExceptionParameterisedConstructor()
        {
            try
            {
                //Arrange
                string className = "MoodAnalyser.MoodAnalyse";
                string constructorName = "WrongConstructorName";
                MoodAnalyse expectedObj = new MoodAnalyse("HAPPY");
                //Act
                object resultObj = MoodAnalyserFactory.CreateMoodAnalyserObjectParameterisedConstructor(className, constructorName, "HAPPY");
            }
            catch (MoodAnalysisException e)
            {
                //Assert
                Assert.AreEqual("constructor not found", e.Message);
            }
        }
        [TestMethod]
        public void TestMethodGivenHappyMessageUsingReflectionWhenProperShouldReturnHappy()
        {
            //Arrange
            string message = "HAPPY";
            string methodName = "AnalyseMood";
            //Act
            string actual = MoodAnalyserFactory.AnalyseMood(message, methodName);
            //Assert
            Assert.AreEqual("HAPPY", actual);
        }
        [TestMethod]
        public void TestMethodGivenImproperMethodNameShouldThrowMoodAnalysisExceptionIndicatingNoSuchMethod()
        {
            try
            {
                //Arrange
                string message = "HAPPY";
                string methodName = "WrongMethodName";
                //Act
                string actual = MoodAnalyserFactory.AnalyseMood(message, methodName);
            }
            catch (MoodAnalysisException e)
            {
                //Assert
                Assert.AreEqual("no such method", e.Message);
            }
        }
    }
}
    


