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
        }
    }
}