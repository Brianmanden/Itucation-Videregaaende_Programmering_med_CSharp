using AbstractClassesInterfacesEnums.Interfaces;

namespace AbstractClassesInterfacesEnums.Models
{
    internal class DeathStar : ILaser
    {
        public void FireLaser()
        {
            Console.WriteLine("Pew pew - lasers fired. An Obi Wan felt a great disturbance in the force, as if millions of voices suddenly cried out in terror.");
        }
    }
}
