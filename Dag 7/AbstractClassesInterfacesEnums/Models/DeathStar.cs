using AbstractClassesInterfacesEnums.Interfaces;

namespace AbstractClassesInterfacesEnums.Models
{
    //---Exercise 2: Interface---

    //b.Create a class called DeathStar that implements the ILaser interface.
    //You decide what the FireLaser method does.If you can't think of anything, just make it write/return "Pew pew".
    
    internal class DeathStar : ILaser
    {
        public void FireLaser()
        {
            Console.WriteLine("Pew pew - lasers fired. An Obi Wan felt a great disturbance in the force, as if millions of voices suddenly cried out in terror.");
        }
    }
}
