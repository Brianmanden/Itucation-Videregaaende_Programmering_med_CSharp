namespace Inheritance.Models
{
    internal class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
        public List<string> Skills { get; set; }

        public void ChangeDepartment(string newDepartment)
        {
            Department = newDepartment;
        }

        public object GetCompleteInfo()
        {
            return new {
                Name = Name,
                Salary = Salary,
                Department = Department,
                Skills = Skills,
            };
        }
    }
}
