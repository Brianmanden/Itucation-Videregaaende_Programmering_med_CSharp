namespace AsyncAwait
{
    internal class Program
    {
        public static void LangsomMetode()
        {
            Thread.Sleep(15000); // current thread
            Console.WriteLine("Langsom metode er færdig");
        }
        public static async Task AndenMetode()
        {
            Console.WriteLine("Task is running somewhere asynchronously... main, you don't have to wait!");
            await Task.Run(LangsomMetode); // control goes back to main
            Console.WriteLine("Anden metode er færdig");
        }
        public static async Task<string> DownloadContent(string url)
        {
            HttpClient client = new HttpClient();
            string result = await client.GetStringAsync(url);
            return result;
        }

        static void Main(string[] args)
        {
            // LangsomMetode(); // main is not responding
            // AndenMetode();

            //Console.WriteLine(DownloadContent("https://www.dmi.dk").Result);
            Console.WriteLine(DownloadContent("https://swapi.dev/api/people/1/").Result);

            //Console.ReadKey();
        }
    }
}