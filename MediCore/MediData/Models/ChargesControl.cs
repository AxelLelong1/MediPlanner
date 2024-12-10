using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("HospitalSer", Name = "XIF411ChargesControl")]
public partial class ChargesControl
{
    [Key]
    public long ChargesControlSer { get; set; }

    public long? HospitalSer { get; set; }

    [StringLength(32)]
    public string? TmpltType { get; set; }

    public int ExtBillCodDisp { get; set; }

    public int ExtBillCodExport { get; set; }

    [StringLength(32)]
    public string ExportType { get; set; } = null!;

    [Column("RVUExport")]
    public int Rvuexport { get; set; }

    [Column("RVUMultiplier")]
    public double? Rvumultiplier { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("ChargesControlSerialNumberNavigation")]
    public virtual ICollection<BillSysChrgWrk> BillSysChrgWrk { get; set; } = new List<BillSysChrgWrk>();

    [InverseProperty("ChargesControlSerialNumberNavigation")]
    public virtual ICollection<BillSysPendingTransactions> BillSysPendingTransactions { get; set; } = new List<BillSysPendingTransactions>();

    [ForeignKey("HospitalSer")]
    [InverseProperty("ChargesControl")]
    public virtual Hospital? HospitalSerNavigation { get; set; }
}
