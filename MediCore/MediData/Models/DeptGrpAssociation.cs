using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ResourceGroupSer", "DepartmentSer", Name = "XAK1DeptGrpAssociation", IsUnique = true)]
[Index("DepartmentSer", Name = "XIF664DeptGrpAssociation")]
public partial class DeptGrpAssociation
{
    [Key]
    public long DeptGrpAssociationSer { get; set; }

    public long DepartmentSer { get; set; }

    public long ResourceGroupSer { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("DepartmentSer")]
    [InverseProperty("DeptGrpAssociation")]
    public virtual Department DepartmentSerNavigation { get; set; } = null!;

    [ForeignKey("ResourceGroupSer")]
    [InverseProperty("DeptGrpAssociation")]
    public virtual ResourceGroup ResourceGroupSerNavigation { get; set; } = null!;
}
