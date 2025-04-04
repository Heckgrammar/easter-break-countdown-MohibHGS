namespace BlankCSDotNet8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                DateTime current = DateTime.Now;
                DateTime target = new DateTime(2025, 4, 4, 15, 15, 0);

                TimeSpan difference = target - current;
                Console.WriteLine(difference.Hours + " hours " + difference.Minutes + " minutes " + difference.Seconds + " seconds" + " till we break for easter");
                Thread.Sleep(1000);

                //while (difference.Seconds < 0) ;
                //{
                //    Console.WriteLine("");
                }
            }
        }
    }
}
