using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgstkh", Schema = "DWH")]
public partial class Stgstkh
{
    [Column("stkh_id")]
    [StringLength(20)]
    public string? StkhId { get; set; }
}
