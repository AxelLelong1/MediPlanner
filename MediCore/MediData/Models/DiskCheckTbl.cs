using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class DiskCheckTbl
{
    [Column("ID")]
    public int? Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DatabaseName { get; set; }

    [Column("RowSizeMB")]
    public int? RowSizeMb { get; set; }

    [Column("LogSizeMB")]
    public int? LogSizeMb { get; set; }

    [Column("DBSizeGB")]
    public int? DbsizeGb { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? RowDrive { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LogDrive { get; set; }

    [Column("FinalDBSizeGB")]
    public int? FinalDbsizeGb { get; set; }

    public bool? FilesOnSameDrive { get; set; }
}
