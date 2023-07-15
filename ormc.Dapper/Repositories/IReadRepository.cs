namespace ormc.Dapper.Repositories
{
    public interface IReadRepository
    {
        System.Collections.Generic.IEnumerable<Models.DapperDriver> GetDrivers();
        System.Collections.Generic.IEnumerable<Models.DapperSeasonResult> GetSeasonResults(int raceSeason);
        System.Collections.Generic.IEnumerable<Models.DapperTrack> GetTracks();
    }
}