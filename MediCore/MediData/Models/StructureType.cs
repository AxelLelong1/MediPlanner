using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("MaterialSer", Name = "XIF865StructureType")]
public partial class StructureType
{
    [Key]
    public long StructureTypeSer { get; set; }

    public long? MaterialSer { get; set; }

    public int? StructureTypeIndex { get; set; }

    [StringLength(16)]
    public string DicomType { get; set; } = null!;

    [StringLength(16)]
    public string? SubType { get; set; }

    public int UserSelectable { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("MaterialSer")]
    [InverseProperty("StructureType")]
    public virtual Material? MaterialSerNavigation { get; set; }

    [InverseProperty("StructureTypeSerNavigation")]
    public virtual ICollection<Structure> Structure { get; set; } = new List<Structure>();
}
