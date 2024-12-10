using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("HospitalSer", Name = "XIF775BillSysHospDeptActivity")]
[Index("DepartmentSer", Name = "XIF776BillSysHospDeptActivity")]
public partial class BillSysHospDeptActivity
{
    [Key]
    public long BillSysHospDeptActivitySer { get; set; }

    [StringLength(64)]
    public string BillSysInstId { get; set; } = null!;

    [StringLength(64)]
    public string BillSysId { get; set; } = null!;

    public long HospitalSer { get; set; }

    public long DepartmentSer { get; set; }

    [StringLength(32)]
    public string CodeType { get; set; } = null!;

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("DepartmentSer")]
    [InverseProperty("BillSysHospDeptActivity")]
    public virtual Department DepartmentSerNavigation { get; set; } = null!;

    [ForeignKey("HospitalSer")]
    [InverseProperty("BillSysHospDeptActivity")]
    public virtual Hospital HospitalSerNavigation { get; set; } = null!;
}
