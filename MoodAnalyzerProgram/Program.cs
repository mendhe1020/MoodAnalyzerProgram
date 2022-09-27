namespace MoodAnalyzerProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MoodAnalyser mood = new MoodAnalyser();
            mood.Analyse("I am in a Sad Mood");
        }
    }
}