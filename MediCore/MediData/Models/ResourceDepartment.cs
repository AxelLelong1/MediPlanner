using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ResourceSer", "DepartmentSer", Name = "XAK1ResourceDepartment", IsUnique = true)]
[Index("DepartmentSer", Name = "XIF464ResourceDepartment")]
public partial class ResourceDepartment
{
    [Key]
    public long ResourceDepartmentSer { get; set; }

    public long DepartmentSer { get; set; }

    public long ResourceSer { get; set; }

    public int DefaultDepartment { get; set; }

    public int AssignedToDepartment { get; set; }

    [StringLength(32)]
    public string AccessRights { get; set; } = null!;

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("ResourceDepartmentSerNavigation")]
    public virtual ICollection<AvailPrefWeeklyPttrn> AvailPrefWeeklyPttrn { get; set; } = new List<AvailPrefWeeklyPttrn>();

    [ForeignKey("DepartmentSer")]
    [InverseProperty("ResourceDepartment")]
    public virtual Department DepartmentSerNavigation { get; set; } = null!;

    [ForeignKey("ResourceSer")]
    [InverseProperty("ResourceDepartment")]
    public virtual Resource ResourceSerNavigation { get; set; } = null!;
}
