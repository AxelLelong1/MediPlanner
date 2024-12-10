using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("InSightive_SimplifiedPrimaryOncoConfiguration_TB", Schema = "DWH")]
public partial class InSightiveSimplifiedPrimaryOncoConfigurationTb
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("GroupID")]
    public int? GroupId { get; set; }

    [Column("ctrResourceSer")]
    public long CtrResourceSer { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [StringLength(255)]
    public string CreatedByUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [StringLength(255)]
    public string ModifiedByUserName { get; set; } = null!;

    [ForeignKey("CtrResourceSer")]
    [InverseProperty("InSightiveSimplifiedPrimaryOncoConfigurationTb")]
    public virtual Doctor CtrResourceSerNavigation { get; set; } = null!;

    [ForeignKey("GroupId")]
    [InverseProperty("InSightiveSimplifiedPrimaryOncoConfigurationTb")]
    public virtual InSightiveSimplifiedGroupConfigurationTb? Group { get; set; }
}
