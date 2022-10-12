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
        //TC 5.1 Given MoodAnalyse Class Name Should Return MoodAnalyser Object

        [Test]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject_UsingParameterizedConstructor()
        {
            object expected = new MoodAnalyser("HAPPY");
            object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyzerProblemStatement.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
        }
        //TC 5.2 Given Improper Class Name Should throw MoodAnalyssiException

        [Test]
        public void GivenImproperClassName_ShouldThrowMoodAnalysisException_UsingParameterizedConstructor()
        {
            string expected = "Class Not Found";
            try
            {
                object moodAnalyseObject = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyzerProblemStatement.MoodAnalyser", "MoodAnalyser");

            }
            catch (MoodAnalysisException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
        //TC 5.3 Given Improper Constructor Name Should throw MoodAnalyssiException

        [Test]
        public void GivenImproperConstructorName_ShouldThrowMoodAnalysisException_UsingParameterizedConstructor()
        {
            string expected = "Constructor is Not Found";
            try
            {
                object moodAnalyseObject = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyzerProblemStatement.MoodAnalyser", "MoodAnalyser");

            }
            catch (MoodAnalysisException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
    }
}