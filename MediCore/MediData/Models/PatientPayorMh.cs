﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PatientPayorSer", "PatientPayorRevCount")]
[Table("PatientPayorMH")]
public partial class PatientPayorMh
{
    [Key]
    public long PatientPayorSer { get; set; }

    [Key]
    public int PatientPayorRevCount { get; set; }

    public long PayorSer { get; set; }

    [StringLength(16)]
    public string? PolicyNumber { get; set; }

    public int PrimaryFlag { get; set; }

    public long PatientSer { get; set; }

    [StringLength(32)]
    public string? PreadmitNumber { get; set; }

    [StringLength(32)]
    public string? AccountNumber { get; set; }

    public double? PrcntOfPaymnt { get; set; }

    [Column(TypeName = "money")]
    public decimal? CoPayment { get; set; }

    [StringLength(64)]
    public string? InsrdName { get; set; }

    [StringLength(32)]
    public string? InsrdMdclNmbr { get; set; }

    [StringLength(64)]
    public string? Relationship { get; set; }

    [StringLength(16)]
    public string? InsrdGroupNumber { get; set; }

    [StringLength(64)]
    public string? InsrdGroupName { get; set; }

    [StringLength(16)]
    public string? InsrdGroupEmpId { get; set; }

    [StringLength(64)]
    public string? InsrdGroupEmpName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? VerificationDate { get; set; }

    [Column("CreatedByHL7")]
    [StringLength(255)]
    public string? CreatedByHl7 { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("PatientPayorSer")]
    [InverseProperty("PatientPayorMh")]
    public virtual PatientPayor PatientPayorSerNavigation { get; set; } = null!;
}
