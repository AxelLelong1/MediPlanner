using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("InSightive_SimplifiedHospDeptConfiguration_TB", Schema = "DWH")]
public partial class InSightiveSimplifiedHospDeptConfigurationTb
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("GroupID")]
    public int GroupId { get; set; }

    [Column("ctrHospitalSer")]
    public long CtrHospitalSer { get; set; }

    [Column("ctrDepartmentSer")]
    public long CtrDepartmentSer { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [StringLength(255)]
    public string CreatedByUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [StringLength(255)]
    public string ModifiedByUserName { get; set; } = null!;

    [ForeignKey("CtrDepartmentSer")]
    [InverseProperty("InSightiveSimplifiedHospDeptConfigurationTb")]
    public virtual Department CtrDepartmentSerNavigation { get; set; } = null!;

    [ForeignKey("CtrHospitalSer")]
    [InverseProperty("InSightiveSimplifiedHospDeptConfigurationTb")]
    public virtual Hospital CtrHospitalSerNavigation { get; set; } = null!;

    [ForeignKey("GroupId")]
    [InverseProperty("InSightiveSimplifiedHospDeptConfigurationTb")]
    public virtual InSightiveSimplifiedGroupConfigurationTb Group { get; set; } = null!;
}
