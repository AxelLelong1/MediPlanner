using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "DateTpInit", "IntvId")]
[Table("pt_tp_tr")]
public partial class PtTpTr
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("date_tp_init", TypeName = "datetime")]
    public DateTime DateTpInit { get; set; }

    [Key]
    [Column("intv_id")]
    public int IntvId { get; set; }

    [Column("gs_author")]
    public int GsAuthor { get; set; }

    [Column("eff_date", TypeName = "datetime")]
    public DateTime EffDate { get; set; }

    [Column("tr_typ")]
    [StringLength(30)]
    public string TrTyp { get; set; } = null!;

    [Column("tr_comp_name")]
    [StringLength(30)]
    public string TrCompName { get; set; } = null!;

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

    [Column("tr_sub_comp_name")]
    [StringLength(60)]
    public string? TrSubCompName { get; set; }

    [ForeignKey("PtId, DateTpInit, IntvId")]
    [InverseProperty("PtTpTr")]
    public virtual PtTpIntv PtTpIntv { get; set; } = null!;
}
