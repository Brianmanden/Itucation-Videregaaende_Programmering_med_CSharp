namespace Inheritance.Models
{
    internal class Daily : Appointment
    {
        private string appointmentType = "Daily";

        public override string AppointmentInfo()
        {
            return $"Type: {appointmentType}\nWhen: {base.Date} \nRegarding: {base.Description}";
        }
    }
}
