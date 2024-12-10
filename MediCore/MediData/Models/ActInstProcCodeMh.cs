using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ActInstProcCodeSer", "ActInstProcCodeRevCount")]
[Table("ActInstProcCodeMH")]
public partial class ActInstProcCodeMh
{
    [Key]
    public long ActInstProcCodeSer { get; set; }

    [Key]
    public int ActInstProcCodeRevCount { get; set; }

    public long ActivityInstanceSer { get; set; }

    public int ActivityInstanceRevCount { get; set; }

    public long ProcedureCodeSer { get; set; }

    public int ProcedureCodeRevCount { get; set; }

    public long? AccountBillingCodeSer { get; set; }

    public int? AccountBillingCodeRevCount { get; set; }

    public long? ModifierSer { get; set; }

    public int? ActivityCodeMdRevCount { get; set; }

    [StringLength(64)]
    public string? Modifier { get; set; }

    public long? Modifier2Ser { get; set; }

    public int? ActivityCodeMd2RevCount { get; set; }

    [StringLength(64)]
    public string? Modifier2 { get; set; }

    public long? Modifier3Ser { get; set; }

    public int? ActivityCodeMd3RevCount { get; set; }

    [StringLength(64)]
    public string? Modifier3 { get; set; }

    public long? Modifier4Ser { get; set; }

    public int? ActivityCodeMd4RevCount { get; set; }

    [StringLength(64)]
    public string? Modifier4 { get; set; }

    public long? Modifier5Ser { get; set; }

    public int? ActivityCodeMd5RevCount { get; set; }

    [StringLength(64)]
    public string? Modifier5 { get; set; }

    public long? Modifier6Ser { get; set; }

    public int? ActivityCodeMd6RevCount { get; set; }

    [StringLength(64)]
    public string? Modifier6 { get; set; }

    public long? Modifier7Ser { get; set; }

    public int? ActivityCodeMd7RevCount { get; set; }

    [StringLength(64)]
    public string? Modifier7 { get; set; }

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    [StringLength(255)]
    public string? ChargeWaivedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FromDateOfService { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ToDateOfService { get; set; }

    [StringLength(255)]
    public string? CompletedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CompletedDateTime { get; set; }

    [StringLength(255)]
    public string? MrkdCmpltdBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? MrkdCmpltdDateTime { get; set; }

    [StringLength(255)]
    public string? ReviewedBy { get; set; }

    [StringLength(255)]
    public string? ExportedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExportedDateTime { get; set; }

    [StringLength(255)]
    public string? ReviewResetBy { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public long? DepartmentSer { get; set; }

    public int? WeeklyChrgFlag { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [ForeignKey("ActInstProcCodeSer")]
    [InverseProperty("ActInstProcCodeMh")]
    public virtual ActInstProcCode ActInstProcCodeSerNavigation { get; set; } = null!;
}
