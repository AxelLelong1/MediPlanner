using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvStudy
{
    [StringLength(25)]
    public string PatientId { get; set; } = null!;

    public long StudySer { get; set; }

    public long PatientSer { get; set; }

    [StringLength(16)]
    public string StudyId { get; set; } = null!;

    [StringLength(64)]
    public string? StudyName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreationDate { get; set; }

    [StringLength(255)]
    public string? CreationUserName { get; set; }

    [StringLength(255)]
    public string? ReferringPhysicianName { get; set; }

    [Column("StudyUID")]
    [StringLength(64)]
    public string StudyUid { get; set; } = null!;

    [StringLength(16)]
    public string? AccessionNumber { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public long? RelatedCourseSer { get; set; }

    public long? RelatedDiagnosisSer { get; set; }
}
