using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("MaterialSer", Name = "XIF844GraphicAnnotationType")]
public partial class GraphicAnnotationType
{
    [Key]
    public long GraphicAnnotationTypeSer { get; set; }

    public int GraphicAnnotationTypeIndex { get; set; }

    public long MaterialSer { get; set; }

    [StringLength(16)]
    public string CurveLabel { get; set; } = null!;

    public int UserSelectable { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("GraphicAnnotationTypeSerNavigation")]
    public virtual ICollection<GraphicAnnotation> GraphicAnnotation { get; set; } = new List<GraphicAnnotation>();

    [ForeignKey("MaterialSer")]
    [InverseProperty("GraphicAnnotationType")]
    public virtual Material MaterialSerNavigation { get; set; } = null!;
}
