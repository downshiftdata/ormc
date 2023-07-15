using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ormc.DataFirst.Models;

[PrimaryKey("RaceSeason", "RaceNumber")]
[Table("RaceResult", Schema = "ormc")]
public partial class RaceResult
{
    [Key]
    public int RaceSeason { get; set; }

    [Key]
    public int RaceNumber { get; set; }

    public int WinnerId { get; set; }
}
