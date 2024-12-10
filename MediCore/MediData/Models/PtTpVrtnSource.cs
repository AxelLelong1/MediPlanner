using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtVrtnSourceId")]
[Table("pt_tp_vrtn_source")]
[Index("PtId", "PtVrtnSourceId", "DateTpInit", Name = "nc1_pt_tp_vrtn_source")]
public partial class PtTpVrtnSource
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_vrtn_source_id")]
    public int PtVrtnSourceId { get; set; }

    [Column("tp_name")]
    [StringLength(20)]
    public string TpName { get; set; } = null!;

    [Column("tp_vers_no")]
    [StringLength(10)]
    public string TpVersNo { get; set; } = null!;

    [Column("date_tp_init", TypeName = "datetime")]
    public DateTime DateTpInit { get; set; }

    [Column("vrtn_source_cls")]
    public int VrtnSourceCls { get; set; }

    [Column("vrtn_source_typ")]
    public int VrtnSourceTyp { get; set; }

    [Column("vrtn_source_desc")]
    public string? VrtnSourceDesc { get; set; }

    [Column("vrtn_source_tstamp", TypeName = "datetime")]
    public DateTime? VrtnSourceTstamp { get; set; }

    [Column("action_taken")]
    public string? ActionTaken { get; set; }

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

    [ForeignKey("VrtnSourceCls, VrtnSourceTyp")]
    [InverseProperty("PtTpVrtnSource")]
    public virtual VrtnSourceTyp VrtnSourceTypNavigation { get; set; } = null!;
}
