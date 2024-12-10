using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("PatientSer", "DepartmentSer", Name = "XAKPatientDepartment", IsUnique = true)]
[Index("DepartmentSer", Name = "XIF781PatientDepartment")]
public partial class PatientDepartment
{
    [Key]
    public long PatientDepartmentSer { get; set; }

    public long PatientSer { get; set; }

    public long DepartmentSer { get; set; }

    public int DefaultFlag { get; set; }

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("DepartmentSer")]
    [InverseProperty("PatientDepartment")]
    public virtual Department DepartmentSerNavigation { get; set; } = null!;

    [ForeignKey("PatientSer")]
    [InverseProperty("PatientDepartment")]
    public virtual Patient PatientSerNavigation { get; set; } = null!;
}
