namespace Inheritance.Models
{
    internal class Appointment
    {
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public virtual string AppointmentInfo()
        {
            return "";
        }
    }
}
