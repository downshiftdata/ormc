namespace ormc.CodeFirst.Models
{
    [System.ComponentModel.DataAnnotations.Schema.Table("Driver")]
    public class CodeFirstDriver
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int? DriverId { get; set; }

        [System.ComponentModel.DataAnnotations.StringLength(128)]
        public string? DriverFirstName { get; set; }

        public string? DriverLastName { get; set; }

        public string? Nation { get; set; }
    }
}