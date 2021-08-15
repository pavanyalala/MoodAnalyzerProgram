using MoodAnalyzerProgram;
using NUnit.Framework;

namespace MoodAnalyzerProgramTest
{
    public class MoodAnalyzerTest
    {
        /// <summary>
        /// Test case 1.1
        /// </summary>
        [Test]
        public void GivenSadMessage_WhenAnalyze_ShouldReturnSad()
        {
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
            string actual = moodAnalyzer.AnalyzeMood("I am in Sad Mood");
            Assert.AreEqual("Sad", actual);
        }
        /// <summary>
        /// Test case 1.2
        /// </summary>
        [Test]
        public void GivenHappyMessage_WhenAnalyze_ShouldReturnHappy()
        {
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
            string actual = moodAnalyzer.AnalyzeMood("I am in Happy Mood");
            Assert.AreEqual("Happy", actual);
        }
    }
}