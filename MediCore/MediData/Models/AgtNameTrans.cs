using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("agt_name_trans")]
[Index("MediDrugName", Name = "nc1_agt_name_trans")]
[Index("PrefAgtName", Name = "nc2_agt_name_trans")]
[Index("UpperAgtName", Name = "nc3_agt_name_trans")]
public partial class AgtNameTrans
{
    [Key]
    [Column("agt_name")]
    [StringLength(50)]
    public string AgtName { get; set; } = null!;

    [Column("medi_drug_name")]
    [StringLength(30)]
    public string? MediDrugName { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("pref_agt_name")]
    [StringLength(50)]
    public string? PrefAgtName { get; set; }

    [Column("agt_cls_desc")]
    [StringLength(20)]
    public string? AgtClsDesc { get; set; }

    [Column("agt_name_abrv")]
    [StringLength(10)]
    public string? AgtNameAbrv { get; set; }

    [Column("agt_cls_typ")]
    public int? AgtClsTyp { get; set; }

    [Column("agt_cls_bill_typ")]
    public int? AgtClsBillTyp { get; set; }

    [Column("agt_cls_use_typ")]
    public int? AgtClsUseTyp { get; set; }

    [Column("custom_bill_typ_ind")]
    [StringLength(1)]
    public string? CustomBillTypInd { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("upper_agt_name")]
    [StringLength(50)]
    public string? UpperAgtName { get; set; }
}
