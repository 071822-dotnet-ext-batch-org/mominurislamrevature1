using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace RepoLayer
{
    public class AdonetAccess
    {
        private static readonly SqlConnection conn = new SqlConnection("Server=tcp:dbpro.database.windows.net,1433;Initial Catalog=Project1;Persist Security Info=False;User ID=[];Password=[];MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

       
        public void testQuery()
        {
 
           /*  
           using (SqlCommand command = new SqlCommand("SELECT * Customers", conn)) {
            conn.Open();
            SqlDataReader? ret = command.ExecuteReader();

            while (ret.Read()){
                Console.WriteLine($"{ret.GetInt32(0)} - {ret[1]}- {ret[2]}");
            }
           }

          }
           conn.Close();
           
       */

        using (SqlCommand command = new SqlCommand($"SELECT FirstName, LastName FROM Customers WHERE FirstName = @x", conn))
        {
            
            conn.Open();
            command.Parameters.AddWithValue("@x", "john");
           SqlDataReader ? ret = command.ExecuteReader();

            while (ret.Read())
            {
                Console.WriteLine($"{ret[0]} - {ret[1]}");
            }
            
        }
      
    }
  }

}