using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("InSightive_SimplifiedDxSiteConfiguration_TB", Schema = "DWH")]
public partial class InSightiveSimplifiedDxSiteConfigurationTb
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("GroupID")]
    public int? GroupId { get; set; }

    public int? TpClsTypeId { get; set; }

    public int? TpClsValueId { get; set; }

    [StringLength(512)]
    public string? DxSiteName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [StringLength(255)]
    public string CreatedByUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [StringLength(255)]
    public string ModifiedByUserName { get; set; } = null!;

    [ForeignKey("GroupId")]
    [InverseProperty("InSightiveSimplifiedDxSiteConfigurationTb")]
    public virtual InSightiveSimplifiedGroupConfigurationTb? Group { get; set; }
}
