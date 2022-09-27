namespace MoodAnalyzerProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MoodAnalyser mood = new MoodAnalyser(null);
            string message = mood.Analyse();
        }
    }
}