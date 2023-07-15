using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace ormc.Ado.Repositories
{
    public class ReadRepository : IReadRepository
    {
        private IConfiguration _Configuration;

        public ReadRepository(IConfiguration configuration)
        {
            _Configuration = configuration;
        }

        public System.Collections.Generic.IEnumerable<Models.AdoDriver> GetDrivers()
        {
            var result = new System.Collections.Generic.List<Models.AdoDriver>();
            using (var connection = new SqlConnection(_Configuration.GetConnectionString("default")))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "ormc.SelectDrivers";
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(new Models.AdoDriver()
                            {
                                DriverId = reader.GetInt32(0),
                                DriverFirstName = reader.GetString(1),
                                DriverLastName = reader.GetString(2),
                                Nation = reader.GetString(3)
                            });
                        }
                    }
                }
            }
            return result;
        }

        public System.Collections.Generic.IEnumerable<Models.AdoSeasonResult> GetSeasonResults(int raceSeason)
        {
            var result = new System.Collections.Generic.List<Models.AdoSeasonResult>();
            using (var connection = new SqlConnection(_Configuration.GetConnectionString("default")))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "ormc.SelectSeasonResults";
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@RaceSeason", System.Data.SqlDbType.Int) { Value = raceSeason });
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(new Models.AdoSeasonResult()
                            {
                                RaceSeason = reader.GetInt32(0),
                                RaceNumber = reader.GetInt32(1),
                                RaceDate = reader.GetDateTime(2),
                                RaceName = reader.GetString(3),
                                TrackName = reader.GetString(4),
                                TrackTypeName = reader.GetString(5),
                                DriverFirstName = reader.IsDBNull(6) ? null : reader.GetString(6),
                                DriverLastName = reader.IsDBNull(7) ? null : reader.GetString(7)
                            });
                        }
                    }
                }
            }
            return result;
        }

        public System.Collections.Generic.IEnumerable<Models.AdoTrack> GetTracks()
        {
            var result = new System.Collections.Generic.List<Models.AdoTrack>();
            using (var connection = new SqlConnection(_Configuration.GetConnectionString("default")))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "ormc.SelectTracks";
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(new Models.AdoTrack()
                            {
                                TrackId = reader.GetInt32(0),
                                TrackName = reader.GetString(1),
                                TrackType = reader.GetInt32(2)
                            });
                        }
                    }
                }
            }
            return result;
        }
    }
}