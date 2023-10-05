using System.Text;
using System.Xml.Linq;

namespace LINQandTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---Exercise 1: LINQ---
            //Included in the folder for today's exercises is the file movies.xml
            //It contains a bit of information about some amazing films.
            #region Exercise 1

            //a.Load the.xml file, and store the file in a variable.
            XElement dataSource = XElement.Load("Data/movies.xml", LoadOptions.PreserveWhitespace);

            //b.Query the file, and store information about the movies in a variable.
            var movies = from movie in dataSource.Descendants("Movie")
                         orderby movie.Element("ReleaseDate").Value ascending
                         select movie;

            //c.Find a way to print some information about all the movies contained in the file.
            //The output has to include:
            //-Title of the movie.
            //- Who directed the movie.
            //- A list of actors.
            foreach (var movie in movies)
            {
                StringBuilder movieOutput = new StringBuilder();

                var actors = from actor in movie.Descendants("Actors").Descendants("Actor")
                             select actor;

                movieOutput.Append($"Title: {movie.Element("Title").Value}. \nDirected by: {movie.Element("Director").Value}");
                movieOutput.Append($"\nActors:\n");
                
                foreach (var actor in actors)
                {
                    movieOutput.Append($"\t{actor.Value} \n");
                }

                Console.WriteLine(movieOutput);
            }

            #endregion

            Console.WriteLine(Environment.NewLine);
            Console.ReadKey();

            #region Exercise 2
            //---Exercise 2: Task---
            //The following url returns some information about a character from a certain franchise:
            //https://swapi.dev/api/people/1

            string jsonOutput = DownloadContent("https://swapi.dev/api/people/1").Result;

            //Print the result, and see if you can make sense of the weird output!
            Console.WriteLine("JSON output from 'https://swapi.dev/api/people/1':");
            Console.WriteLine(jsonOutput);
            
            Console.WriteLine(Environment.NewLine);
            Console.ReadKey();

            //(feel free to test your method with different changes to the url - you might get some interesting results!)
            string htmlOutput = DownloadContent("https://www.kree8tive.dk").Result;
            Console.WriteLine("Raw weird HTML output from 'https://www.kree8tive.dk':");
            Console.WriteLine(htmlOutput);

            //Run your method with the provided url.
            #endregion

            Console.WriteLine("Press any key");
            Console.ReadKey();
        }

        // Exercise 2
        // Create an async method, which can download some content from a specific url and return the result.
        private static async Task<string> DownloadContent(string url)
        {
            HttpClient client = new HttpClient();
            string result = await client.GetStringAsync(url);
            return result;
        }
    }
}