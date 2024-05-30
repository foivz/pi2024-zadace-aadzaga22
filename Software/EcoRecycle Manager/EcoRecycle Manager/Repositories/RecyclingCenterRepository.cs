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
    public class RecyclingCenterRepository
    {
        public static RecyclingCenter GetRecyclingCenter(int centerID)
        {
            RecyclingCenter center = null;

            string sql = $"SELECT * FROM [dbo].[RecyclingCenter] WHERE CenterID = {centerID}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                center = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return center;
        }

        public static List<RecyclingCenter> GetRecyclingCenters()
        {
            var centers = new List<RecyclingCenter>();

            string sql = "SELECT * FROM [dbo].[RecyclingCenter]";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                RecyclingCenter center = CreateObject(reader);
                centers.Add(center);
            }

            reader.Close();
            DB.CloseConnection();

            return centers;
        }

        private static RecyclingCenter CreateObject(SqlDataReader reader)
        {
            int centerID = int.Parse(reader["CenterID"].ToString());
            string name = reader["Name"].ToString();
            string address = reader["Address"].ToString();
            string workingHours = reader["WorkingHours"].ToString();
            string contactNumber = reader["ContactNumber"].ToString();

            var center = new RecyclingCenter
            {
                CenterID = centerID,
                Name = name,
                Address = address,
                WorkingHours = workingHours,
                ContactNumber = contactNumber
            };

            return center;
        }
    }
}
