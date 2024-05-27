using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoRecycle_Manager.Models
{
    public class Transaction
    {
        public int TransactionID { get; set; }
        public DateTime DateTime { get; set; }
        public int CustomerID { get; set; }
        public int CenterID { get; set; }
        public int EmployeeID { get; set; }
        public int WasteTypeID { get; set; }
        public decimal Quantity { get; set; }
        public string Unit { get; set; }

        public override string ToString()
        {
            return $"Transaction ID: {TransactionID}, Date: {DateTime}, Customer ID: {CustomerID}, Center ID: {CenterID}, Employee ID: {EmployeeID}, Waste Type ID: {WasteTypeID}, Quantity: {Quantity} {Unit}";
        }
    }

}

