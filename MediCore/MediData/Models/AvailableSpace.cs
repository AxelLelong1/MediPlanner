using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class AvailableSpace
{
    [StringLength(10)]
    [Unicode(false)]
    public string? Drive { get; set; }

    [Column("DiskSpaceInMB")]
    public int? DiskSpaceInMb { get; set; }
}
