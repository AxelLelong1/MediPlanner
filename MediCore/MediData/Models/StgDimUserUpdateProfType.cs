using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimUserUpdateProfType", Schema = "DWH")]
public partial class StgDimUserUpdateProfType
{
    [Column("ctrinst_id")]
    [StringLength(30)]
    public string? CtrinstId { get; set; }

    [Column("ctruserid")]
    [StringLength(255)]
    public string? Ctruserid { get; set; }
}
