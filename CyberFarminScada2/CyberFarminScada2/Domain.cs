using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Linq;
using System.Web;

namespace CyberFarminScada2
{
    public class Domain
    {
        public Object[] getTempData()
        {
            List<Double> list = new List<Double>();
            
            string connStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;

            SqlCeConnection connection =
            new SqlCeConnection(@"Data Source=|DataDirectory|\Database1.sdf");
            connection.Open();
            SqlCeCommand command = new SqlCeCommand("SELECT Temp FROM Temperature", connection);

            SqlCeDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                list.Add(reader.GetDouble(0));
            }

           object[] objects =  list.Cast<object>().ToArray();

           return objects;
        }
        public string[] getTempCategories()
        {
            List<String> list = new List<String>();

            string connStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;

            SqlCeConnection connection =
            new SqlCeConnection(@"Data Source=|DataDirectory|\Database1.sdf");
            connection.Open();
            SqlCeCommand command = new SqlCeCommand("SELECT Stamp FROM Temperature", connection);

            SqlCeDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                list.Add(reader.GetString(0));
            }

            string[] objects = list.Cast<string>().ToArray();

            return objects;
        }
    }
}