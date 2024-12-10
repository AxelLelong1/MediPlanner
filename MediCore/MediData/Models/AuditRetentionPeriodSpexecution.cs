using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("AuditRetentionPeriodSPExecution", Schema = "DWH")]
public partial class AuditRetentionPeriodSpexecution
{
    [Column("ID")]
    public long Id { get; set; }

    [Column("DB_ID")]
    public int? DbId { get; set; }

    public int? CurrentRetentionPeriod { get; set; }

    public int? NewRetentionPeriod { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ExecutionDateTime { get; set; }
}
