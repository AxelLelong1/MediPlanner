using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtTxDecId", "RevisionNo")]
[Table("pt_tx_dec_mh")]
public partial class PtTxDecMh
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_tx_dec_id")]
    public int PtTxDecId { get; set; }

    [Key]
    [Column("revision_no")]
    public int RevisionNo { get; set; }

    [Column("date_tp_init", TypeName = "datetime")]
    public DateTime DateTpInit { get; set; }

    [Column("tp_name")]
    [StringLength(20)]
    public string TpName { get; set; } = null!;

    [Column("dec_typ")]
    public int DecTyp { get; set; }

    [Column("dec_date", TypeName = "datetime")]
    public DateTime? DecDate { get; set; }

    [Column("cycle_no")]
    public int? CycleNo { get; set; }

    [Column("cycle_day")]
    public int? CycleDay { get; set; }

    [Column("dec_userid")]
    [StringLength(255)]
    public string? DecUserid { get; set; }

    [Column("dec_inst_id")]
    [StringLength(30)]
    public string? DecInstId { get; set; }

    [Column("tx_dec_rsn_id")]
    public int? TxDecRsnId { get; set; }

    [Column("dec_rsn_desc")]
    [StringLength(255)]
    public string? DecRsnDesc { get; set; }

    [Column("dec_qty")]
    public int? DecQty { get; set; }

    [Column("dec_qty_unit")]
    public int? DecQtyUnit { get; set; }

    [Column("vrtn_ind")]
    [StringLength(1)]
    public string? VrtnInd { get; set; }

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

    [Column("dec_rsn_typ")]
    public int? DecRsnTyp { get; set; }

    [Column("vrbl_id")]
    public int? VrblId { get; set; }

    [Column("pt_tx_id")]
    public int? PtTxId { get; set; }
}
