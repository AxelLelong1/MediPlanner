using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "InstTrCompId")]
[Table("inst_tr_comp")]
[Index("ClsSchemeId", Name = "nc1_inst_tr_comp")]
[Index("InstId", "ClsSchemeId", Name = "nc2_inst_tr_comp")]
public partial class InstTrComp
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("inst_tr_comp_id")]
    public int InstTrCompId { get; set; }

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

    [Column("cls_scheme_id")]
    public int? ClsSchemeId { get; set; }

    [Column("pt_enter_ind")]
    [StringLength(1)]
    public string? PtEnterInd { get; set; }
}
