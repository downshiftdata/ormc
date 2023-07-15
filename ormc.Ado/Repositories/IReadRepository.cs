namespace ormc.Ado.Repositories
{
    public interface IReadRepository
    {
        System.Collections.Generic.IEnumerable<Models.AdoDriver> GetDrivers();
        System.Collections.Generic.IEnumerable<Models.AdoSeasonResult> GetSeasonResults(int raceSeason);
        System.Collections.Generic.IEnumerable<Models.AdoTrack> GetTracks();
    }
}