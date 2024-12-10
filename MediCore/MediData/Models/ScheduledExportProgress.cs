using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ScheduledExportId", "IdType", "IdValue")]
[Table("scheduled_export_progress")]
public partial class ScheduledExportProgress
{
    [Key]
    [Column("scheduled_export_id")]
    public int ScheduledExportId { get; set; }

    [Key]
    [Column("id_type")]
    [StringLength(2)]
    public string IdType { get; set; } = null!;

    [Key]
    [Column("id_value")]
    [StringLength(20)]
    public string IdValue { get; set; } = null!;

    [Column("file_name")]
    [StringLength(512)]
    public string? FileName { get; set; }
}
