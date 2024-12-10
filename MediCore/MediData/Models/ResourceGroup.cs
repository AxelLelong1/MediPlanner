using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ResourceGroupCode", "DepartmentSer", Name = "XAK1ResourceGroup", IsUnique = true)]
[Index("DepartmentSer", Name = "XIF662ResourceGroup")]
[Index("DicomcodeValueSer", Name = "XIF970ResourceGroup")]
public partial class ResourceGroup
{
    [Key]
    public long ResourceGroupSer { get; set; }

    public long? DepartmentSer { get; set; }

    [StringLength(64)]
    public string ResourceGroupCode { get; set; } = null!;

    [StringLength(32)]
    public string GroupType { get; set; } = null!;

    public long? DerivedFromResourceGroupSer { get; set; }

    public int? NoEditFlag { get; set; }

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [Column("DICOMCodeValueSer")]
    public long? DicomcodeValueSer { get; set; }

    [StringLength(64)]
    public string? WorklistType { get; set; }

    [InverseProperty("EscalationGroupSerNavigation")]
    public virtual ICollection<Activity> ActivityEscalationGroupSerNavigation { get; set; } = new List<Activity>();

    [InverseProperty("ResourceGroupSerNavigation")]
    public virtual ICollection<Activity> ActivityResourceGroupSerNavigation { get; set; } = new List<Activity>();

    [InverseProperty("UpdCpescalationGroupSerNavigation")]
    public virtual ICollection<Activity> ActivityUpdCpescalationGroupSerNavigation { get; set; } = new List<Activity>();

    [InverseProperty("UpdCpresourceGroupSerNavigation")]
    public virtual ICollection<Activity> ActivityUpdCpresourceGroupSerNavigation { get; set; } = new List<Activity>();

    [InverseProperty("ResourceGroupSerNavigation")]
    public virtual ICollection<Attendee> Attendee { get; set; } = new List<Attendee>();

    [ForeignKey("DepartmentSer")]
    [InverseProperty("ResourceGroup")]
    public virtual Department? DepartmentSerNavigation { get; set; }

    [InverseProperty("ResourceGroupSerNavigation")]
    public virtual ICollection<DeptGrpAssociation> DeptGrpAssociation { get; set; } = new List<DeptGrpAssociation>();

    [ForeignKey("DicomcodeValueSer")]
    [InverseProperty("ResourceGroup")]
    public virtual DicomcodeValue? DicomcodeValueSerNavigation { get; set; }

    [InverseProperty("ResourceGroupSerNavigation")]
    public virtual ICollection<GroupResource> GroupResource { get; set; } = new List<GroupResource>();

    [InverseProperty("ResourceGroupSerNavigation")]
    public virtual ICollection<ProcedureItemResource> ProcedureItemResource { get; set; } = new List<ProcedureItemResource>();
}
