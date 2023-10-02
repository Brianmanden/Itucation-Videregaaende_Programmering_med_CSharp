namespace Inheritance.Models
{
    internal class Onetime : Appointment
    {
        private string appointmentType = "OneTime";

        public override string AppointmentInfo()
        {
            return $"Type: {appointmentType}\nWhen: {base.Date} \nRegarding: {base.Description}";
        }
    }
}
