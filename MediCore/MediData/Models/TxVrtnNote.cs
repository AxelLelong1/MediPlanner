using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtVisitId", "TpName", "PhaseSeqNo", "DateTpInit", "TxVrtnNoteTyp", "VrtnDate")]
[Table("tx_vrtn_note")]
public partial class TxVrtnNote
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
    [Column("tx_vrtn_note_typ")]
    public int TxVrtnNoteTyp { get; set; }

    [Key]
    [Column("vrtn_date", TypeName = "datetime")]
    public DateTime VrtnDate { get; set; }

    [Column("tx_vrtn_note")]
    public string? TxVrtnNote1 { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

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

    [Column("vrtn_rsn_typ")]
    public int? VrtnRsnTyp { get; set; }

    [Column("rsn_typ_ind")]
    [StringLength(1)]
    public string? RsnTypInd { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [ForeignKey("PtId, PtVisitId, TpName, PhaseSeqNo, DateTpInit, VrtnDate")]
    [InverseProperty("TxVrtnNote")]
    public virtual TxVrtn TxVrtn { get; set; } = null!;

    [ForeignKey("TxVrtnNoteTyp")]
    [InverseProperty("TxVrtnNote")]
    public virtual TxVrtnNoteTyp TxVrtnNoteTypNavigation { get; set; } = null!;
}
