using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class SessionProcedureTemplate
{
    [Key]
    public long SessionProcedureTemplateSer { get; set; }

    [StringLength(16)]
    public string SessionProcedureTemplateId { get; set; } = null!;

    [StringLength(64)]
    public string? SessionProcedureTemplateName { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreationDate { get; set; }

    [StringLength(255)]
    public string? CreationUser { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public int ReadOnly { get; set; }

    [InverseProperty("SessionProcedureTemplateSerNavigation")]
    public virtual ICollection<SessionProcedureTemplatePart> SessionProcedureTemplatePart { get; set; } = new List<SessionProcedureTemplatePart>();
}
