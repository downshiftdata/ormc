using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ormc.DataFirst.Models;

[Table("TrackType", Schema = "ormc")]
public partial class TrackType
{
    [Key]
    public int TrackTypeId { get; set; }

    [StringLength(128)]
    public string TrackTypeName { get; set; } = null!;
}
