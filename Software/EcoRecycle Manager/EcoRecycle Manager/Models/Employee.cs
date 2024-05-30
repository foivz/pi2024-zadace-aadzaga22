using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoRecycle_Manager.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string FullName => $"{Name} {Surname}";

        public override string ToString()
        {
            return $"Employee ID: {EmployeeID}, Name: {Name}, Surname: {Surname}, Position: {Position}, Contact Number: {ContactNumber}, Email: {Email}";
        }
    }
}
