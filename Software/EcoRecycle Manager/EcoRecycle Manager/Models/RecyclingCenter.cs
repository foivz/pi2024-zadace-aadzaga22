using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoRecycle_Manager.Models
{
    public class RecyclingCenter
    {
        public int CenterID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string WorkingHours { get; set; }
        public string ContactNumber { get; set; }

        public override string ToString()
        {
            return $"Center ID: {CenterID}, Name: {Name}, Address: {Address}, Working Hours: {WorkingHours}, Contact Number: {ContactNumber}";
        }
    }
}
