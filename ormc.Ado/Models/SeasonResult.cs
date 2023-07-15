namespace ormc.Ado.Models
{
    public class AdoSeasonResult
    {
        public int RaceSeason { get; set; }
        public int RaceNumber { get; set; }
        public System.DateTime RaceDate { get; set; }
        public string? RaceName { get; set; }
        public string? TrackName { get; set; }
        public string? TrackTypeName { get; set; }
        public string? DriverFirstName { get; set; }
        public string? DriverLastName { get; set; }
    }
}