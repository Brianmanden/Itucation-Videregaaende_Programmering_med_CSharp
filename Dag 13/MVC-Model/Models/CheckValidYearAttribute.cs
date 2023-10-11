using System.ComponentModel.DataAnnotations;

namespace MVC_Model.Models
{
    internal class CheckValidYear : ValidationAttribute
    {
        public override bool IsValid(object value) {
            int year = (int)value;
            
            if (year < 1960)
            {
                ErrorMessage = "No good albums released before 1960";
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}