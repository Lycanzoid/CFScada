using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading;
using System.Configuration;
using System.Data.SqlClient;

namespace Tester
{
    class Program
    {
       
        
        static void Main(string[] args)
        {

            throw new Exception(ConfigurationManager.ConnectionStrings["mcn"].ConnectionString);
            /**  string con = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;

              using (SqlConnection myConnection = new SqlConnection(con))
              {
                  string oString = "Select * from temperature_readings";
                  SqlCommand oCmd = new SqlCommand(oString, myConnection);
                  myConnection.Open();
              
                
                  using (SqlDataReader oReader = oCmd.ExecuteReader())
                  {
                      while (oReader.Read())
                      {
                          Console.WriteLine(oReader["temperature"].ToString());
                      }

                      myConnection.Close();
                  }
              } **/
        }
    }
}
