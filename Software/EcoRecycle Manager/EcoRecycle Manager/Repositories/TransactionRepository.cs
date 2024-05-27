﻿using DBLayer;
using EcoRecycle_Manager.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoRecycle_Manager.Repositories
{
    public class TransactionRepository
    {
        public static Transaction GetTransaction(int id)
        {
            Transaction transaction = null;

            string sql = $"SELECT * FROM Transaction WHERE TransactionID = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                transaction = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return transaction;
        }

        public static List<Transaction> GetTransactions()
        {
            var transactions = new List<Transaction>();

            string sql = "SELECT * FROM Transaction";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Transaction transaction = CreateObject(reader);
                transactions.Add(transaction);
            }

            reader.Close();
            DB.CloseConnection();

            return transactions;
        }

        private static Transaction CreateObject(SqlDataReader reader)
        {
            int transactionID = int.Parse(reader["TransactionID"].ToString());
            DateTime dateTime = DateTime.Parse(reader["DateTime"].ToString());
            int customerID = int.Parse(reader["CustomerID"].ToString());
            int centerID = int.Parse(reader["CenterID"].ToString());
            int employeeID = int.Parse(reader["EmployeeID"].ToString());
            int wasteTypeID = int.Parse(reader["WasteTypeID"].ToString());
            decimal quantity = decimal.Parse(reader["Quantity"].ToString());
            string unit = reader["Unit"].ToString();

            var transaction = new Transaction
            {
                TransactionID = transactionID,
                DateTime = dateTime,
                CustomerID = customerID,
                CenterID = centerID,
                EmployeeID = employeeID,
                WasteTypeID = wasteTypeID,
                Quantity = quantity,
                Unit = unit
            };

            return transaction;
        }




    }
}
