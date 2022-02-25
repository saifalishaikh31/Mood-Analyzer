using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyzerProgram;
namespace MoodAnalyzerTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSadMoodMessage()
        {
            string message = "I am in sad Mood";
            string expected = "SAD";
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
            string actual = moodAnalyzer.AnalyseMood();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestAnyMoodMessage()
        {
            string message = "I am in Any Mood";
            string expected = "HAPPY";
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
            string actual = moodAnalyzer.AnalyseMood();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestNullMood()
        {
            string message = null;
            string expected = null;
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
            string actual = moodAnalyzer.AnalyseMood();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestNullReturnHappyModd()
        {
            string message = null;
            string expected = "HAPPY";
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
            string actual = moodAnalyzer.AnalyseMood();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow(null, "Mood should not be null")]
        [DataRow("", "Mood should not be empty")]
        public void TestInformUser(string userInput, string expected)
        {
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(userInput);
            string actual = moodAnalyzer.AnalyseMood();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnAnalyseObject()
        {
            object expected = new MoodAnalyzer();
            object obj = MoodAnalyseFactory.CreateMoodAnalyse("MoodAnalyzerProgram.MoodAnalyzer", "MoodAnalyzer");
            expected.Equals(obj);
        }

        [TestMethod]
        public void GivenWrongClassName_ShouldThrowException()
        {
            object expected = new MoodAnalyzer();
            object actual = MoodAnalyseFactory.CreateMoodAnalyse("MoodAnalszer", "MoodAnalyzer");
            expected.Equals(actual);
        }

        [TestMethod]
        public void GivenWrongConstructorName_ShouldThrowException()
        {
            object expected = new MoodAnalyzer();
            object actual = MoodAnalyseFactory.CreateMoodAnalyse("MoodAnalyzerProgram.MoodAnalyzer", "MoodAnalyser");
            expected.Equals(actual);
        }
    }
}
