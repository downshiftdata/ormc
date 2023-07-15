using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ormc.DataFirst.Models;

[Table("Driver", Schema = "ormc")]
[Index("DriverFirstName", "DriverLastName", Name = "uc_ormc_Driver", IsUnique = true)]
public partial class Driver
{
    [Key]
    public int DriverId { get; set; }

    [StringLength(128)]
    public string DriverFirstName { get; set; } = null!;

    [StringLength(128)]
    public string DriverLastName { get; set; } = null!;

    [StringLength(128)]
    public string Nation { get; set; } = null!;
}
