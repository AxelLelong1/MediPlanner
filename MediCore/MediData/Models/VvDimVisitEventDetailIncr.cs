using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimVisitEventDetailIncr
{
    [Column("ctrpt_id")]
    [StringLength(20)]
    public string? CtrptId { get; set; }

    [Column("ctrpt_visit_id")]
    public int? CtrptVisitId { get; set; }

    [Column("ctrinst_id")]
    [StringLength(30)]
    public string? CtrinstId { get; set; }

    [Column("ctrunavl_hdr_id")]
    public int CtrunavlHdrId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EventStartDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EventEndDateTime { get; set; }

    [Column("DimDateID_StartDateTime")]
    public long DimDateIdStartDateTime { get; set; }

    [Column("DimDateID_EndDateTime")]
    public long DimDateIdEndDateTime { get; set; }

    [StringLength(1)]
    public string? EventType { get; set; }

    [StringLength(100)]
    public string? EventTypeDescription { get; set; }

    [Column("user_inst_id")]
    [StringLength(30)]
    public string? UserInstId { get; set; }

    [Column("userid")]
    [StringLength(255)]
    public string? Userid { get; set; }

    [Column("loc_id")]
    public int LocId { get; set; }

    [StringLength(1)]
    public string? ValidEntryIndicator { get; set; }

    [StringLength(1)]
    public string? PatientIndicator { get; set; }

    [StringLength(1)]
    public string? ProfIndicator { get; set; }

    [StringLength(1)]
    public string? LocationIndicator { get; set; }

    [StringLength(200)]
    public string? PatientUnavailComment { get; set; }

    [StringLength(40)]
    public string? EventTypeEventName { get; set; }

    [StringLength(40)]
    public string? EventTypeSchEventName { get; set; }
}
