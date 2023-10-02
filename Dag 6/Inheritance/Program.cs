using Inheritance.Models;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

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

            Onetime onetime = new Onetime { Date = DateTime.Now.AddHours(2), Description = "Uhh oohh... Go see the principle"};
            Daily daily = new Daily { Date = DateTime.Now.AddHours(1), Description = "Write program.. at least a 'Hello World'-example."};
            Montly montly = new Montly{ Date = DateTime.Now.AddHours(4), Description = "Tidy up code" };
            #endregion

            Console.WriteLine(Environment.NewLine);

            //---Exercise 3---
            //Create a list of objects from Exercise 2.
            //Use a loop to print out all your AppointmentInfo!
            #region Exercise 3
            List<Appointment> appointments = new List<Appointment> { onetime, daily, montly };
            foreach (Appointment appointment in appointments)
            {
                Console.WriteLine(appointment.AppointmentInfo());
                Console.WriteLine(Environment.NewLine);
            }
            #endregion


            //---Exercise 4---
            #region Exercise 4
            //a.Create a class Artist. An artist has a name and a genre.
            //Define a PlaySong method, which returns an informative string including the artist name and genre.
            Artist artist1 = new Artist { Name = "Motörhead", Genre = "Rock´n Roll" };
            Artist artist2 = new Artist { Name = "Sepultura", Genre = "Iron Samba" };

            //b.Create a derived class Band which inherits from Artist.
            //A band has their best song, in addition to all the information from the Artist super class.
            //Override the PlaySong method, since you now have some more information to include!
            Band band1 = new Band { Name = "Black Sabbath", Genre = "Pioneers of Heavy Metal", BestSong = "Children of the Grave" };
            Band band2 = new Band { Name = "Deep Purple", Genre = "Hard Rock", BestSong = "Smoke on the Water" };

            //c.For this exercise, SoloArtist is a derived class of Band.
            //They include no new attributes, but the PlaySong method has to reflect the artist going solo.
            SoloArtist soloArtist1 = new SoloArtist { Name = "Ozzy", Genre = "Heavy Metal", BestSong = "Crazy Train" };
            SoloArtist soloArtist2 = new SoloArtist { Name = "Dio", Genre = "Heavy Metal", BestSong = "Holy Diver" };

            //d.Create 2 objects of each class, and add them all to a list.
            //Use the list to play a little concert, by having all the musicians PlaySong
            List<Artist> tonightsProgram = new List<Artist> {
                artist1,
                artist2,
                band1,
                band2,
                soloArtist1,
                soloArtist2
            };

            Console.WriteLine("Tonights Program:");
            Console.WriteLine("-----------------");
            foreach (Artist artist in tonightsProgram)
            {
                Console.WriteLine(artist.PlaySong());
                //Console.WriteLine(Environment.NewLine);
            }

            #endregion

            Console.ReadKey();
        }
    }
}