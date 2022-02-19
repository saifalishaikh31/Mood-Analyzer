﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    }
}
