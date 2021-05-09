namespace P03.BehavioralPattern
{
    using P03.BehavioralPattern.CommandPattern;

    public class StartUp
    {
        public static void Main()
        {
            var engine = new Engine();

            engine.Run();
        }
    }
}
