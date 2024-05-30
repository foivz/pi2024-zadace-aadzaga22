using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoRecycle_Manager.Models
{
    public class WasteType
    {
        public int WasteTypeID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"Waste Type ID: {WasteTypeID}, Name: {Name}, Description: {Description}";
        }
    }
}
