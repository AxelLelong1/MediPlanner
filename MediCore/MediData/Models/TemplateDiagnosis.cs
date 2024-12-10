using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("DiagnosisSer", Name = "XIE2TemplateDiagnosis")]
[Index("TemplateSer", Name = "XIF669TemplateDiagnosis")]
public partial class TemplateDiagnosis
{
    [Key]
    public long TemplateDiagnosisSer { get; set; }

    public long TemplateSer { get; set; }

    public long DiagnosisSer { get; set; }

    public int TemplateRevCount { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("TemplateSer")]
    [InverseProperty("TemplateDiagnosis")]
    public virtual Template TemplateSerNavigation { get; set; } = null!;
}
