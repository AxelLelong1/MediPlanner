using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimPatientVisitTracking
{
    [Column("ctrpt_id")]
    [StringLength(30)]
    public string? CtrptId { get; set; }

    [Column("ctrpt_visit_id")]
    public int CtrptVisitId { get; set; }

    [Column("ctrpt_visit_tracking_id")]
    public int CtrptVisitTrackingId { get; set; }

    [Column("ctrinst_id")]
    [StringLength(30)]
    public string? CtrinstId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime VisitTrackingDateTime { get; set; }

    public int VisitTrackingType { get; set; }

    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    public int VisitTrackingSeq { get; set; }

    [StringLength(30)]
    public string? VisitTrackingTypeDesc { get; set; }

    [StringLength(2)]
    public string? VisitTrackingAbrv { get; set; }
}
