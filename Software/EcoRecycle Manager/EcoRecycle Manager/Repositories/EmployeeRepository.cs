using DBLayer;
using EcoRecycle_Manager.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoRecycle_Manager.Repositories
{
    public class EmployeeRepository
    {
        public static Employee GetEmployee(int employeeID)
        {
            Employee employee = null;

            string sql = $"SELECT * FROM [dbo].[Employee] WHERE EmployeeID = {employeeID}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                employee = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return employee;
        }

        public static List<Employee> GetEmployees()
        {
            var employees = new List<Employee>();

            string sql = "SELECT * FROM [dbo].[Employee]";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Employee employee = CreateObject(reader);
                employees.Add(employee);
            }

            reader.Close();
            DB.CloseConnection();

            return employees;
        }

        private static Employee CreateObject(SqlDataReader reader)
        {
            int employeeID = int.Parse(reader["EmployeeID"].ToString());
            string name = reader["Name"].ToString();
            string surname = reader["Surname"].ToString();
            string position = reader["Position"].ToString();
            string contactNumber = reader["ContactNumber"].ToString();
            string email = reader["Email"].ToString();

            var employee = new Employee
            {
                EmployeeID = employeeID,
                Name = name,
                Surname = surname,
                Position = position,
                ContactNumber = contactNumber,
                Email = email
            };

            return employee;
        }
    }
}
