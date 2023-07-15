using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ormc.DataFirst.Models;

[PrimaryKey("RaceSeason", "RaceNumber")]
[Table("Race", Schema = "ormc")]
public partial class Race
{
    [Key]
    public int RaceSeason { get; set; }

    [Key]
    public int RaceNumber { get; set; }

    public int TrackId { get; set; }

    [StringLength(128)]
    public string RaceName { get; set; } = null!;

    [Column(TypeName = "date")]
    public DateTime RaceDate { get; set; }
}
