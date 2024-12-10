using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtVisitId", "TpName", "PhaseSeqNo", "DateTpInit", "VrtnDate")]
[Table("tx_vrtn")]
public partial class TxVrtn
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Key]
    [Column("tp_name")]
    [StringLength(20)]
    public string TpName { get; set; } = null!;

    [Column("tp_vers_no")]
    [StringLength(10)]
    public string? TpVersNo { get; set; }

    [Key]
    [Column("phase_seq_no")]
    public int PhaseSeqNo { get; set; }

    [Key]
    [Column("date_tp_init", TypeName = "datetime")]
    public DateTime DateTpInit { get; set; }

    [Key]
    [Column("vrtn_date", TypeName = "datetime")]
    public DateTime VrtnDate { get; set; }

    [Column("vrtn_typ")]
    public int? VrtnTyp { get; set; }

    [Column("vrtn_cls")]
    public int? VrtnCls { get; set; }

    [Column("vrtn_desc")]
    public string? VrtnDesc { get; set; }

    [Column("spsr_checked")]
    [StringLength(1)]
    public string? SpsrChecked { get; set; }

    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Column("userid_link")]
    [StringLength(255)]
    public string UseridLink { get; set; } = null!;

    [Column("vrtn_action")]
    public int? VrtnAction { get; set; }

    [Column("reviewing_spsr")]
    [StringLength(10)]
    public string? ReviewingSpsr { get; set; }

    [Column("spsr_id")]
    [StringLength(30)]
    public string? SpsrId { get; set; }

    [Column("vrbl_id")]
    public int? VrblId { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [ForeignKey("PtId, PtVisitId")]
    [InverseProperty("TxVrtn")]
    public virtual PtVisit PtVisit { get; set; } = null!;

    [InverseProperty("TxVrtn")]
    public virtual ICollection<TxVrtnNote> TxVrtnNote { get; set; } = new List<TxVrtnNote>();

    [ForeignKey("PtId, VrblId")]
    [InverseProperty("TxVrtn")]
    public virtual VrblOrder? VrblOrder { get; set; }
}
