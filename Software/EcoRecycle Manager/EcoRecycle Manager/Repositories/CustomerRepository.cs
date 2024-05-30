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
    public class CustomerRepository
    {
        public static Customer GetCustomer(int customerID)
        {
            Customer customer = null;

            string sql = $"SELECT * FROM [dbo].[Customer] WHERE CustomerID = {customerID}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                customer = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return customer;
        }

        public static List<Customer> GetCustomers()
        {
            var customers = new List<Customer>();

            string sql = "SELECT * FROM [dbo].[Customer]";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Customer customer = CreateObject(reader);
                customers.Add(customer);
            }

            reader.Close();
            DB.CloseConnection();

            return customers;
        }

        private static Customer CreateObject(SqlDataReader reader)
        {
            int customerID = int.Parse(reader["CustomerID"].ToString());
            string name = reader["Name"].ToString();
            string surname = reader["Surname"].ToString();
            string address = reader["Address"].ToString();
            string phoneNumber = reader["PhoneNumber"].ToString();
            string email = reader["Email"].ToString();

            var customer = new Customer
            {
                CustomerID = customerID,
                Name = name,
                Surname = surname,
                Address = address,
                PhoneNumber = phoneNumber,
                Email = email
            };

            return customer;
        }
    }
}
