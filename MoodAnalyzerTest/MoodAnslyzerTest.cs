using MoodAnalyzerProgram;
namespace MoodAnalyzerTest
{
    public class Tests
    {
        [Test]
        public void GivenSadMessage_WhenAnalyse_ShouldReturnSad()
        {
            string message = "I am in Sad Mood";
            MoodAnalyser mood = new MoodAnalyser(message);
            string actual = mood.Analyse();
            Assert.AreEqual(actual, "SAD");
        }

        [Test]
        public void GivenHappyMessage_WhenAnalyse_ShouldReturnSad()
        {
            string message = "I am in Happy Mood";
            MoodAnalyser mood = new MoodAnalyser(message);
            string actual = mood.Analyse();
            Assert.AreEqual(actual, "HAPPY");
        }

        [Test]
        public void GivenNullMessage_WhenAnalyse_ShouldReturnSad()
        {
            string message = null;
            MoodAnalyser mood = new MoodAnalyser(message);
            string actual = mood.Analyse();
            Assert.AreEqual(actual, "HAPPY");
        }

        [Test]
        public void GivenEmptyMessage_WhenAnalyse_ShouldReturnHappy()
        {
            string message = string.Empty;
            MoodAnalyser mood = new MoodAnalyser(message);
            try
            {
                string actual = mood.Analyse();
            }catch(MoodAnalysisException ex)
            {
                Assert.AreEqual(ex.Message, "Message is Empty");
            }
        }

    }
}