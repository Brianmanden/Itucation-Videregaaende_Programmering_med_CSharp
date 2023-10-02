using Inheritance.Models;
using System.Reflection;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---Exercise 1---
            //Class: Employee
            //This employee might want to change department at some point.
            //- Necessary variables: name, salary, department
            //- Implement a list of skills, and decide how to manage it in your class
            //- Implement a way to get complete info of the employee
            //- Add functionality to change department
            #region Exercise 1

            Employee employee1 = new Employee();
            employee1.Name = "Lizette";
            employee1.Salary = 123.45M;
            employee1.Department = "Internship";
            employee1.Skills = new List<string> { "Programming", "Documentation", "Debugging" };

            employee1.ChangeDepartment("IT");

            object employeeInfo = employee1.GetCompleteInfo();

            var properties = employeeInfo.GetType().GetProperties();
            foreach (PropertyInfo prop in properties)
            {
                if (prop.PropertyType == typeof(List<string>))
                {
                    Console.WriteLine(prop.Name + " : ");
                    PropertyInfo values = employee1.GetType().GetProperty(prop.Name);
                    List<string> skills = values.GetValue(employee1) as List<string>;
                    foreach (string skill in skills)
                    {
                        Console.WriteLine($"\t{skill}");
                    }
                }
                else
                {
                    Console.WriteLine(prop.Name + " : " + prop.GetValue(employeeInfo, null).ToString());
                }
            }
            #endregion

            Console.WriteLine(Environment.NewLine);

            //---Exercise 2---
            //Implement a superclass Appointment and the following subclasses:
            //Onetime, Daily, Monthly.
            //An appointment has a description(for example: "see the dentist") and a date.
            //Define a method AppointmentInfo that returns a description, date, and
            //whether the appointment is daily, monthly or onetime.
            #region Exercise 2

            Onetime onetime = new Onetime {
                Date = DateTime.Now.AddHours(2),
                Description = "Uhh oohh... Go see the principle"
            };
            Console.WriteLine(onetime.AppointmentInfo());
            Console.WriteLine(Environment.NewLine);

            Daily daily = new Daily {
                Date = DateTime.Now.AddHours(1),
                Description = "Write program.. at least a 'Hello World'-example."
            };
            Console.WriteLine(daily.AppointmentInfo());
            Console.WriteLine(Environment.NewLine);

            Montly montly = new Montly
            {
                Date = DateTime.Now.AddHours(4),
                Description = "Tidy up code"
            };
            Console.WriteLine(montly.AppointmentInfo());
            #endregion

            Console.WriteLine(Environment.NewLine);

            #region Exercise 3

            #endregion

            Console.ReadKey();
        }
    }
}