using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace ormc.Dapper.Repositories
{
    public class ReadRepository : IReadRepository
    {
        private IConfiguration _Configuration;

        public ReadRepository(IConfiguration configuration)
        {
            _Configuration = configuration;
        }

        public System.Collections.Generic.IEnumerable<Models.DapperDriver> GetDrivers()
        {
            using (var connection = new SqlConnection(_Configuration.GetConnectionString("default")))
            {
                connection.Open();
                return connection.QueryAsync<Models.DapperDriver>(
                    "ormc.SelectDrivers",
                    commandType: System.Data.CommandType.StoredProcedure)
                    .Result;
            }
        }

        public System.Collections.Generic.IEnumerable<Models.DapperTrack> GetTracks()
        {
            using (var connection = new SqlConnection(_Configuration.GetConnectionString("default")))
            {
                connection.Open();
                return connection.QueryAsync<Models.DapperTrack>(
                    "ormc.SelectTracks",
                    commandType: System.Data.CommandType.StoredProcedure)
                    .Result;
            }
        }

        public System.Collections.Generic.IEnumerable<Models.DapperSeasonResult> GetSeasonResults(int raceSeason)
        {
            using (var connection = new SqlConnection(_Configuration.GetConnectionString("default")))
            {
                connection.Open();
                return connection.QueryAsync<Models.DapperSeasonResult>(
                    "ormc.SelectSeasonResults",
                    param: new {raceSeason},
                    commandType: System.Data.CommandType.StoredProcedure)
                    .Result;
            }
        }
    }
}