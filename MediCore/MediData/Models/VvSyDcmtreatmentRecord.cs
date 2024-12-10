using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvSyDcmtreatmentRecord
{
    [StringLength(25)]
    public string PatientId { get; set; } = null!;

    [Column("StudyUID")]
    [StringLength(64)]
    public string StudyUid { get; set; } = null!;

    [Column("SeriesUID")]
    [StringLength(64)]
    public string SeriesUid { get; set; } = null!;

    [Column("InstanceUID")]
    [StringLength(64)]
    public string InstanceUid { get; set; } = null!;

    public long InstanceSer { get; set; }

    [Column("DCMType")]
    [StringLength(15)]
    [Unicode(false)]
    public string Dcmtype { get; set; } = null!;

    [Column("SOPClassSer")]
    public long SopclassSer { get; set; }

    [Column("ReferencedPlanUID")]
    [StringLength(64)]
    public string ReferencedPlanUid { get; set; } = null!;

    public int DicomSeqNumber { get; set; }

    public int FractionNumber { get; set; }
}
