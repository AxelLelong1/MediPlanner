using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("pt_user_defined_label")]
public partial class PtUserDefinedLabel
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Column("user_define_label_1")]
    [StringLength(50)]
    public string? UserDefineLabel1 { get; set; }

    [Column("user_defined_visible_1_ind")]
    [StringLength(1)]
    public string? UserDefinedVisible1Ind { get; set; }

    [Column("user_define_label_2")]
    [StringLength(50)]
    public string? UserDefineLabel2 { get; set; }

    [Column("user_defined_visible_2_ind")]
    [StringLength(1)]
    public string? UserDefinedVisible2Ind { get; set; }

    [Column("user_define_label_3")]
    [StringLength(50)]
    public string? UserDefineLabel3 { get; set; }

    [Column("user_defined_visible_3_ind")]
    [StringLength(1)]
    public string? UserDefinedVisible3Ind { get; set; }

    [Column("user_define_label_4")]
    [StringLength(50)]
    public string? UserDefineLabel4 { get; set; }

    [Column("user_defined_visible_4_ind")]
    [StringLength(1)]
    public string? UserDefinedVisible4Ind { get; set; }

    [Column("user_define_label_5")]
    [StringLength(50)]
    public string? UserDefineLabel5 { get; set; }

    [Column("user_defined_visible_5_ind")]
    [StringLength(1)]
    public string? UserDefinedVisible5Ind { get; set; }

    [Column("user_define_label_6")]
    [StringLength(50)]
    public string? UserDefineLabel6 { get; set; }

    [Column("user_defined_visible_6_ind")]
    [StringLength(1)]
    public string? UserDefinedVisible6Ind { get; set; }

    [Column("user_define_label_7")]
    [StringLength(50)]
    public string? UserDefineLabel7 { get; set; }

    [Column("user_defined_visible_7_ind")]
    [StringLength(1)]
    public string? UserDefinedVisible7Ind { get; set; }

    [Column("user_define_label_8")]
    [StringLength(50)]
    public string? UserDefineLabel8 { get; set; }

    [Column("user_defined_visible_8_ind")]
    [StringLength(1)]
    public string? UserDefinedVisible8Ind { get; set; }

    [Column("user_define_label_9")]
    [StringLength(50)]
    public string? UserDefineLabel9 { get; set; }

    [Column("user_defined_visible_9_ind")]
    [StringLength(1)]
    public string? UserDefinedVisible9Ind { get; set; }

    [Column("user_define_label_10")]
    [StringLength(50)]
    public string? UserDefineLabel10 { get; set; }

    [Column("user_defined_visible_10_ind")]
    [StringLength(1)]
    public string? UserDefinedVisible10Ind { get; set; }

    [Column("user_define_label_11")]
    [StringLength(50)]
    public string? UserDefineLabel11 { get; set; }

    [Column("user_defined_visible_11_ind")]
    [StringLength(1)]
    public string? UserDefinedVisible11Ind { get; set; }

    [Column("user_define_label_12")]
    [StringLength(50)]
    public string? UserDefineLabel12 { get; set; }

    [Column("user_defined_visible_12_ind")]
    [StringLength(1)]
    public string? UserDefinedVisible12Ind { get; set; }

    [Column("user_define_label_13")]
    [StringLength(50)]
    public string? UserDefineLabel13 { get; set; }

    [Column("user_defined_visible_13_ind")]
    [StringLength(1)]
    public string? UserDefinedVisible13Ind { get; set; }

    [Column("user_define_label_14")]
    [StringLength(50)]
    public string? UserDefineLabel14 { get; set; }

    [Column("user_defined_visible_14_ind")]
    [StringLength(1)]
    public string? UserDefinedVisible14Ind { get; set; }

    [Column("user_define_label_15")]
    [StringLength(50)]
    public string? UserDefineLabel15 { get; set; }

    [Column("user_defined_visible_15_ind")]
    [StringLength(1)]
    public string? UserDefinedVisible15Ind { get; set; }

    [Column("user_define_label_16")]
    [StringLength(50)]
    public string? UserDefineLabel16 { get; set; }

    [Column("user_defined_visible_16_ind")]
    [StringLength(1)]
    public string? UserDefinedVisible16Ind { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string TransLogMuserid { get; set; } = null!;

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string TransLogMinstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
