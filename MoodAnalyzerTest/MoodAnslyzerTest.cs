using MoodAnalyzerProgram;
namespace MoodAnalyzerTest
{
    public class Tests
    {
        public MoodAnalyser mood;
       [SetUp]
        public void Setup()
        {
            mood = new MoodAnalyser();
        }

        [Test]
        public void GivenSadMessage_WhenAnalyse_ShouldReturnSad()
        {
            string message = "I am in Sad Mood";
            string actual = mood.Analyse(message);
            Assert.AreEqual(actual, "SAD");
        }

        [Test]
        public void GivenHappyMessage_WhenAnalyse_ShouldReturnSad()
        {
            string message = "I am in Happy Mood";
            string actual = mood.Analyse(message);
            Assert.AreEqual(actual, "HAPPY");
        }
    }
}