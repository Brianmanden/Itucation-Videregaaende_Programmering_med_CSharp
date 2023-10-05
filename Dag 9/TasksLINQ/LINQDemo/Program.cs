using System.Xml.Linq;

namespace LINQDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr =
            //{
            //    34, 56, 78, 98, 87, 76, 65, 54, 43, 32, 24, 54, 75, 86, 96, 85, 84, 73, 79,
            //    34, 56, 78, 98, 87, 76, 65, 54, 43, 32, 24, 54, 75, 86, 96, 85, 84, 73, 79,
            //    34, 56, 78, 98, 87, 76, 65, 54, 43, 32, 24, 54, 75, 86, 96, 85, 84, 73, 79,
            //    34, 56, 78, 98, 87, 76, 65, 54, 43, 32, 24, 54, 75, 86, 96, 85, 84, 73, 79
            //};
            //IEnumerable<int> qryResult = from someVal in arr
            //                             where someVal > 70
            //                             orderby someVal ascending
            //                             select someVal;
            ////Console.WriteLine(qryResult);
            //foreach (var item in qryResult)
            //{
            //    Console.WriteLine(item);
            //}

            // ------------- XML --------------
            XElement empFile = XElement.Load("employees.xml"); // Right click file, properties, change "Do not Copy" to "Copy always"

            var XMLQueryResult = from emp in empFile.Descendants("Employee")
                                 orderby emp.Element("Department").Value
                                 select emp;
            foreach(var e in XMLQueryResult)
            {
                Console.WriteLine($"Employee -> {e.Element("FirstName").Value} " + 
                    $"{e.Element("LastName").Value} works in {e.Element("Department").Value} " +
                    $"in the city of: {e.Element("Location").Value}");
            }
        }
    }
}