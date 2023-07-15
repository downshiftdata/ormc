using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace ormc.Ado.Repositories
{
    public class WriteRepository : IWriteRepository
    {
        private IConfiguration _Configuration;

        public WriteRepository(IConfiguration configuration)
        {
            _Configuration = configuration;
        }

        public void AddDriver(Models.AdoDriver value)
        {
            using (var connection = new SqlConnection(_Configuration.GetConnectionString("default")))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "ormc.Driver_Insert";
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@DriverId", System.Data.SqlDbType.Int) { Direction = System.Data.ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@DriverFirstName", System.Data.SqlDbType.NVarChar, 128) { Value = value.DriverFirstName });
                    command.Parameters.Add(new SqlParameter("@DriverLastName", System.Data.SqlDbType.NVarChar, 128) { Value = value.DriverLastName });
                    command.Parameters.Add(new SqlParameter("@Nation", System.Data.SqlDbType.NVarChar, 128) { Value = value.Nation });
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}