using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("AuraParentPackageJobStatus", Schema = "DWH")]
public partial class AuraParentPackageJobStatus
{
    [Column("ID")]
    public long Id { get; set; }

    [Column("LogID")]
    public int? LogId { get; set; }

    public byte RunStatus { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DateCreation { get; set; }
}
