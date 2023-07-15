using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ormc.DataFirst.Models;

[Table("Track", Schema = "ormc")]
public partial class Track
{
    [Key]
    public int TrackId { get; set; }

    [StringLength(128)]
    public string TrackName { get; set; } = null!;

    public int TrackType { get; set; }
}
