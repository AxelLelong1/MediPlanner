using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("loinc")]
public partial class Loinc
{
    [Key]
    [Column("loinc_cd")]
    [StringLength(10)]
    public string LoincCd { get; set; } = null!;

    [Column("component")]
    [StringLength(255)]
    public string Component { get; set; } = null!;

    [Column("property")]
    [StringLength(255)]
    public string? Property { get; set; }

    [Column("time_aspct")]
    [StringLength(255)]
    public string? TimeAspct { get; set; }

    [Column("system")]
    [StringLength(255)]
    public string? System { get; set; }

    [Column("scale_typ")]
    [StringLength(255)]
    public string? ScaleTyp { get; set; }

    [Column("method_typ")]
    [StringLength(255)]
    public string? MethodTyp { get; set; }

    [Column("class")]
    [StringLength(255)]
    public string? Class { get; set; }

    [Column("status")]
    [StringLength(255)]
    public string? Status { get; set; }

    [Column("relatednames2")]
    public string? Relatednames2 { get; set; }

    [Column("shortname")]
    [StringLength(255)]
    public string? Shortname { get; set; }

    [Column("long_common_name")]
    [StringLength(255)]
    public string? LongCommonName { get; set; }

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

    [Column("loinc_cls_typ")]
    public int? LoincClsTyp { get; set; }

    [Column("hl7_field_subfield_id")]
    [StringLength(255)]
    public string? Hl7FieldSubfieldId { get; set; }

    [Column("external_copyright_notice")]
    public string? ExternalCopyrightNotice { get; set; }

    [Column("ver_last_chg")]
    [StringLength(255)]
    public string? VerLastChg { get; set; }

    [Column("external_copyright_link")]
    [StringLength(255)]
    public string? ExternalCopyrightLink { get; set; }

    [Column("panel_typ")]
    [StringLength(255)]
    public string? PanelTyp { get; set; }

    [Column("ask_order_entry")]
    [StringLength(255)]
    public string? AskOrderEntry { get; set; }

    [Column("associated_obs")]
    [StringLength(255)]
    public string? AssociatedObs { get; set; }
}
