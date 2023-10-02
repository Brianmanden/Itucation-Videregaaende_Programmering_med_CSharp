namespace Inheritance.Models
{
    internal class Montly : Appointment
    {
        private string appointmentType = "Monthly";

        public override string AppointmentInfo()
        {
            return $"Type: {appointmentType}\nWhen: {base.Date} \nRegarding: {base.Description}";
        }
    }
}
