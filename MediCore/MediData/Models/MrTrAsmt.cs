using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "TrTyp", "TrCompName", "ResultUseTyp", "PtTrAsmtId")]
[Table("mr_tr_asmt")]
public partial class MrTrAsmt
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("tr_typ")]
    [StringLength(30)]
    public string TrTyp { get; set; } = null!;

    [Key]
    [Column("tr_comp_name")]
    [StringLength(30)]
    public string TrCompName { get; set; } = null!;

    [Key]
    [Column("result_use_typ")]
    public int ResultUseTyp { get; set; }

    [Key]
    [Column("pt_tr_asmt_id")]
    public int PtTrAsmtId { get; set; }

    [Column("pt_visit_id")]
    public int? PtVisitId { get; set; }

    [Column("mr_tstamp", TypeName = "datetime")]
    public DateTime? MrTstamp { get; set; }

    [Column("tr_sub_comp_name")]
    [StringLength(60)]
    public string? TrSubCompName { get; set; }

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

    [ForeignKey("ResultUseTyp")]
    [InverseProperty("MrTrAsmt")]
    public virtual ResultUseTyp ResultUseTypNavigation { get; set; } = null!;
}
