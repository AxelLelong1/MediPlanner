using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("DoseTemplateId", Name = "XAK1DoseTemplate", IsUnique = true)]
public partial class DoseTemplate
{
    [Key]
    public long DoseTemplateSer { get; set; }

    [StringLength(16)]
    public string DoseTemplateId { get; set; } = null!;

    [StringLength(64)]
    public string? DoseTemplateName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreationDate { get; set; }

    [StringLength(255)]
    public string? CreationUserName { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [Column(TypeName = "image")]
    public byte[]? IsodoseLevels { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }
}
