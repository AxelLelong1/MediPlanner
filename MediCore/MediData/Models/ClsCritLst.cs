using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("SchemeAuthor", "EffDate", "ClsValue")]
[Table("cls_crit_lst")]
public partial class ClsCritLst
{
    [Key]
    [Column("scheme_author")]
    public int SchemeAuthor { get; set; }

    [Key]
    [Column("eff_date", TypeName = "datetime")]
    public DateTime EffDate { get; set; }

    [Key]
    [Column("cls_value")]
    public int ClsValue { get; set; }

    [Column("cls_value_desc")]
    public string ClsValueDesc { get; set; } = null!;

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

    [Column("cls_value_disp")]
    [StringLength(10)]
    public string? ClsValueDisp { get; set; }

    [Column("cls_crit_lst_id")]
    public int? ClsCritLstId { get; set; }

    [Column("seq_no")]
    public int? SeqNo { get; set; }
}
