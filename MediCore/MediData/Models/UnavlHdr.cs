using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "UnavlHdrId")]
[Table("unavl_hdr")]
[Index("PtId", "PtVisitId", Name = "nc1_unavl_hdr")]
[Index("FillerApptId", Name = "nc2_unavl_hdr")]
[Index("PtId", "PtVisitId", "SlotSize", Name = "nc3_unavl_hdr")]
[Index("InstId", "UnavlHdrId", "SlotSize", Name = "nc4_unavl_hdr")]
[Index("UnavlFrom", Name = "nc5_unavl_hdr")]
[Index("InstId", "LocId", Name = "nc6_unavl_hdr")]
[Index("UserInstId", "Userid", Name = "nc7_unavl_hdr")]
[Index("ReadOnlyInd", "PtId", "PtVisitId", Name = "nc8_unavl_hdr")]
[Index("PtId", "PtVisitId", "ReadOnlyInd", Name = "nc9_unavl_hdr")]
public partial class UnavlHdr
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("unavl_hdr_id")]
    public int UnavlHdrId { get; set; }

    [Column("unavl_from", TypeName = "datetime")]
    public DateTime UnavlFrom { get; set; }

    [Column("unavl_to", TypeName = "datetime")]
    public DateTime UnavlTo { get; set; }

    [Column("slot_size")]
    public int? SlotSize { get; set; }

    [Column("filler_appt_id")]
    [StringLength(75)]
    public string? FillerApptId { get; set; }

    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }

    [Column("pt_visit_id")]
    public int? PtVisitId { get; set; }

    [Column("event_typ")]
    [StringLength(1)]
    public string? EventTyp { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("pt_ind")]
    [StringLength(1)]
    public string? PtInd { get; set; }

    [Column("prof_ind")]
    [StringLength(1)]
    public string? ProfInd { get; set; }

    [Column("loc_ind")]
    [StringLength(1)]
    public string? LocInd { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("user_inst_id")]
    [StringLength(30)]
    public string? UserInstId { get; set; }

    [Column("userid")]
    [StringLength(255)]
    public string? Userid { get; set; }

    [Column("loc_id")]
    public int? LocId { get; set; }

    [Column("read_only_ind")]
    [StringLength(1)]
    public string? ReadOnlyInd { get; set; }
}
