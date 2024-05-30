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
    public class WasteTypeRepository
    {
        public static WasteType GetWasteType(int wasteTypeID)
        {
            WasteType wasteType = null;

            string sql = $"SELECT * FROM [dbo].[WasteType] WHERE WasteTypeID = {wasteTypeID}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                wasteType = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return wasteType;
        }

        public static List<WasteType> GetWasteTypes()
        {
            var wasteTypes = new List<WasteType>();

            string sql = "SELECT * FROM [dbo].[WasteType]";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                WasteType wasteType = CreateObject(reader);
                wasteTypes.Add(wasteType);
            }

            reader.Close();
            DB.CloseConnection();

            return wasteTypes;
        }

        private static WasteType CreateObject(SqlDataReader reader)
        {
            int wasteTypeID = int.Parse(reader["WasteTypeID"].ToString());
            string name = reader["Name"].ToString();
            string description = reader["Description"].ToString();

            var wasteType = new WasteType
            {
                WasteTypeID = wasteTypeID,
                Name = name,
                Description = description
            };

            return wasteType;
        }
    }
}
