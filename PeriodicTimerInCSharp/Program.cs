namespace PeriodicTimerInCSharp
{
    public class Program
    {
        public static PeriodicTimer periodicTimer = new PeriodicTimer(new TimeSpan(0, 0, 5));
        static async Task Main(string[] args)
        {
            while (await periodicTimer.WaitForNextTickAsync())
            {
                Console.WriteLine(DateTime.Now.ToString("o"));
            }

        }
    }
}
