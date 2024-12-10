using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvPrmryDiagnosisWithStages
{
    [Column("TStage")]
    [StringLength(32)]
    public string? Tstage { get; set; }

    [Column("NStage")]
    [StringLength(32)]
    public string? Nstage { get; set; }

    [Column("MStage")]
    [StringLength(32)]
    public string? Mstage { get; set; }

    [StringLength(32)]
    public string? AltStage { get; set; }

    [Column(TypeName = "decimal(11, 4)")]
    public decimal? TumorSize { get; set; }

    [StringLength(32)]
    public string? StageMethod { get; set; }

    [StringLength(32)]
    public string? SummaryStage { get; set; }

    public long? DiagnosisSer { get; set; }
}
