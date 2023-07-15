using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace ormc.Dapper.Repositories
{
    public class WriteRepository : IWriteRepository
    {
        private IConfiguration _Configuration;

        public WriteRepository(IConfiguration configuration)
        {
            _Configuration = configuration;
        }

        public void AddDriver(Models.DapperDriver value)
        {
            using (var connection = new SqlConnection(_Configuration.GetConnectionString("default")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@DriverId", System.DBNull.Value, System.Data.DbType.Int32, System.Data.ParameterDirection.InputOutput);
                parameters.Add("@DriverFirstName", value.DriverFirstName);
                parameters.Add("@DriverLastName", value.DriverLastName);
                parameters.Add("@Nation", value.Nation);
                connection.Open();
                var result = connection.ExecuteAsync(
                    "ormc.Driver_Insert",
                    param: parameters,
                    commandType: System.Data.CommandType.StoredProcedure)
                    .Result;
                System.Console.WriteLine("DriverId={0}", parameters.Get<int>("@DriverId"));
            }
        }

        public void EditDriver(Models.DapperDriver value)
        {
            using (var connection = new SqlConnection(_Configuration.GetConnectionString("default")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@DriverId", System.DBNull.Value, System.Data.DbType.Int32);
                parameters.Add("@DriverFirstName", value.DriverFirstName);
                parameters.Add("@DriverLastName", value.DriverLastName);
                parameters.Add("@Nation", value.Nation);
                connection.Open();
                var result = connection.ExecuteAsync(
                    "ormc.Driver_Update",
                    param: parameters,
                    commandType: System.Data.CommandType.StoredProcedure)
                    .Result;
            }
        }

        public void RemoveDriver(Models.DapperDriver value)
        {
            using (var connection = new SqlConnection(_Configuration.GetConnectionString("default")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@DriverId", System.DBNull.Value, System.Data.DbType.Int32);
                connection.Open();
                var result = connection.ExecuteAsync(
                    "ormc.Driver_Delete",
                    param: parameters,
                    commandType: System.Data.CommandType.StoredProcedure)
                    .Result;
            }
        }
    }
}