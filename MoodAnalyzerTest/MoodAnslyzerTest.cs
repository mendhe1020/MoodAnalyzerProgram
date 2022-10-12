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
            string actual = mood.Analyser();
            Assert.AreEqual(actual, "SAD");
        }

        [Test]
        public void GivenHappyMessage_WhenAnalyse_ShouldReturnSad()
        {
            string message = "I am in Happy Mood";
            MoodAnalyser mood = new MoodAnalyser(message);
            string actual = mood.Analyser();
            Assert.AreEqual(actual, "HAPPY");
        }

        [Test]
        public void GivenNullMessage_WhenAnalyse_ShouldReturnSad()
        {
            string message = null;
            MoodAnalyser mood = new MoodAnalyser(message);
            string actual = mood.Analyser();
            Assert.AreEqual(actual, "HAPPy");
        }

        [Test]
        public void GivenEmptyMessage_WhenAnalyse_ShouldReturnHappy()
        {
            string message = string.Empty;
            MoodAnalyser mood = new MoodAnalyser(message);
            try
            {
                string actual = mood.Analyser();
            }
            catch (MoodAnalysisException ex)
            {
                Assert.AreEqual(ex.Message, "Message is Empty");
            }
        }

        [Test]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            string message = null;
            object actual = new MoodAnalyser();
            object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyzerProblemStatement.MoodAnalyser", "MoodAnalyser");
            actual.Equals(obj);
        }

        [Test]
        public void GivenImproperClassName_ShouldThrowMoodAnalysisException()
        {
            string actual = "Class Not Found";
            try
            {
                object moodAnalyseObject = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyzerProblemStatement.MoodAnalyser", "MoodAnalyser");

            }
            catch (MoodAnalysisException exception)
            {
                Assert.AreEqual(actual, exception.Message);
            }
        }

        [Test]
        public void GivenImproperConstructor_ShouldThrowMoodAnalysisException()
        {
            string actual = "Constructor is Not Found";
            try
            {
                object moodAnalyseObject = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyzerProblemStatement.MoodAnalyser", "MoodAnalyser");
            }
            catch (MoodAnalysisException exception)
            {
                Assert.AreEqual(actual, exception.Message);
            }
        }
    }
}