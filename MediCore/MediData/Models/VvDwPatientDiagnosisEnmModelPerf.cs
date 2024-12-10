using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDwPatientDiagnosisEnmModelPerf
{
    [Column("icd_cd")]
    [StringLength(16)]
    public string? IcdCd { get; set; }

    public int DiagnosisTableName { get; set; }

    [StringLength(1)]
    public string? DiagnosisType { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateStamp { get; set; }

    public int? DxSite { get; set; }

    [StringLength(250)]
    public string? DiagnosisDescription { get; set; }

    [StringLength(16)]
    public string? ObjectStatus { get; set; }

    [StringLength(16)]
    public string DiagnosisCode { get; set; } = null!;

    [StringLength(255)]
    public string? DiagnosisTable { get; set; }

    [StringLength(100)]
    public string? SiteDesc { get; set; }

    [Column("ctrDiagnosisSer")]
    public long? CtrDiagnosisSer { get; set; }

    [Column("ctrPatientSer")]
    public long? CtrPatientSer { get; set; }

    [Column("ctrpt_id")]
    [StringLength(20)]
    public string CtrptId { get; set; } = null!;
}
