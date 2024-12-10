using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("GraphicAnnotationTypeSer", Name = "XIF837GraphicAnnotation")]
[Index("MaterialSer", Name = "XIF843GraphicAnnotation")]
[Index("ImageSer", Name = "XIF872GraphicAnnotation")]
public partial class GraphicAnnotation
{
    [Key]
    public long GraphicAnnotationSer { get; set; }

    public long GraphicAnnotationTypeSer { get; set; }

    public long ImageSer { get; set; }

    [StringLength(16)]
    public string GraphicAnnotationId { get; set; } = null!;

    [StringLength(64)]
    public string? GraphicAnnotationName { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    public long? MaterialSer { get; set; }

    [StringLength(254)]
    public string? FileName { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("GraphicAnnotationTypeSer")]
    [InverseProperty("GraphicAnnotation")]
    public virtual GraphicAnnotationType GraphicAnnotationTypeSerNavigation { get; set; } = null!;

    [ForeignKey("ImageSer")]
    [InverseProperty("GraphicAnnotation")]
    public virtual Image1 ImageSerNavigation { get; set; } = null!;

    [ForeignKey("MaterialSer")]
    [InverseProperty("GraphicAnnotation")]
    public virtual Material? MaterialSerNavigation { get; set; }
}
