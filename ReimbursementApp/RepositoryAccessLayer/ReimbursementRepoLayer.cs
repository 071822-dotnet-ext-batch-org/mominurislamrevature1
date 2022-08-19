using Models;
using System.Data.SqlClient;
//using System.Runtime.InteropServices;

namespace RepositoryAccessLayer
{
    public class ReimbursementRepoLayer
    {
        public async Task<List<ReimbursementReq>> RequestsAsync(int type)

        {
            SqlConnection conn = new SqlConnection("Server=tcp:dbpro.database.windows.net,1433;Initial Catalog=Project1;Persist Security Info=False;User ID=;Password=;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            using (SqlCommand command = new SqlCommand($"SELECT * FROM Reimbursement WHERE Status = @type", conn))
            {

                command.Parameters.AddWithValue("@type", type);
                conn.Open();
                SqlDataReader? ret = await command.ExecuteReaderAsync();
                List<ReimbursementReq> rList = new List<ReimbursementReq>();
                while (ret.Read())
                {
                    ReimbursementReq r = new ReimbursementReq((Guid)ret[0], (Guid)ret[1], ret.GetString(2), ret.GetDecimal(3), ret.GetInt32(4));
                    rList.Add(r);
                }
                conn.Close();
                return rList;

            }
        }
        public async Task<UpdateReRequestDto> UpdateRequestAsync(Guid reimbursementId, int status)
        {
            SqlConnection conn = new SqlConnection("Server=tcp:dbpro.database.windows.net,1433;Initial Catalog=Project1;Persist Security Info=False;User ID=;Password=;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            using (SqlCommand command = new SqlCommand($"UPDATE Reimbursement SET Status = @status WHERE ReimbursementID = @id", conn))
            {
                command.Parameters.AddWithValue("@id", reimbursementId);
                command.Parameters.AddWithValue("status", status);
                conn.Open();
                int ret = await command.ExecuteNonQueryAsync();
                if (ret == 1)
                {
                    conn.Close();
                    //call the requestByid()
                    // created 2 neew methods to get the request by 
                    // ID And get the employee by id. Thes are methods that would be useful and reusable
                    // Mark does not want to do 80% for the project

                    //call the updaterequesttByid() . This method will join to return the employee name 
                    // along with the relavent detail and return DTO


                    UpdateReRequestDto urbi = await this.UpdateRequestByIdAsync(reimbursementId);
                   // UpdateReRequestDto urbi = await this.UpdateRequestAsync(reimbursementId, status);

                    // return.Close();
                    return urbi;

                }

                conn.Close();
                return null;
            }

        }

        

        public async Task<bool> IsManagerAsync(Guid employeeID)
        {
            SqlConnection conn = new SqlConnection("Server=tcp:dbpro.database.windows.net,1433;Initial Catalog=Project1;Persist Security Info=False;User ID=;Password=;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            using (SqlCommand command = new SqlCommand($"SELECT IsManager FROM Employees WHERE EmployeeID = @id", conn))
            {

                command.Parameters.AddWithValue("@id", employeeID);
                conn.Open();
                SqlDataReader? ret = await command.ExecuteReaderAsync();
                if (ret.Read() && ret.GetBoolean(0))

                {
                    conn.Close();
                    return true;
                }
                conn.Close();
                return false;

            }
        }





        public async Task<UpdateReRequestDto> UpdateRequestByIdAsync(Guid reimbursementId)
        {
            SqlConnection conn = new SqlConnection("Server=tcp:dbpro.database.windows.net,1433;Initial Catalog=Project1;Persist Security Info=False;User ID=;Password=;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            using (SqlCommand command = new SqlCommand($"SELECT ReimbursementID,FirstName, LastName, Status FROM Employees LEFT JOIN  Reimbursement ON EmployeeID = FK_EmployeeId WHERE ReimbursementID = @reimbursementId", conn))
            {

                command.Parameters.AddWithValue("@reimbursementId", reimbursementId);

                conn.Open();
                SqlDataReader? ret = await command.ExecuteReaderAsync();

                if (ret.Read())
                {

                    UpdateReRequestDto r = new UpdateReRequestDto(ret.GetGuid(0), ret.GetString(1), ret.GetString(2), ret.GetInt32(3));
                    conn.Close();

                    return r;
                }
            }

            conn.Close();
            return null;
        }


    }

} 

 