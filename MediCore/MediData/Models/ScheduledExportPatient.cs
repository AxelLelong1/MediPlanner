using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ScheduledExportId", "PtId")]
[Table("scheduled_export_patient")]
public partial class ScheduledExportPatient
{
    [Key]
    [Column("scheduled_export_id")]
    public int ScheduledExportId { get; set; }

    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Column("patient_ser")]
    public long? PatientSer { get; set; }
}
