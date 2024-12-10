using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "RefId")]
[Table("ref_def")]
public partial class RefDef
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("ref_id")]
    [StringLength(15)]
    public string RefId { get; set; } = null!;

    [Column("ref_desc")]
    [StringLength(255)]
    public string? RefDesc { get; set; }

    [Column("tbl_typ")]
    [StringLength(1)]
    public string TblTyp { get; set; } = null!;

    [Column("actual_tbl_name")]
    [StringLength(30)]
    public string? ActualTblName { get; set; }

    [Column("key1_col_name")]
    [StringLength(64)]
    public string? Key1ColName { get; set; }

    [Column("key1_col_desc")]
    [StringLength(30)]
    public string? Key1ColDesc { get; set; }

    [Column("key2_col_name")]
    [StringLength(64)]
    public string? Key2ColName { get; set; }

    [Column("key2_col_desc")]
    [StringLength(30)]
    public string? Key2ColDesc { get; set; }

    [Column("key3_col_name")]
    [StringLength(64)]
    public string? Key3ColName { get; set; }

    [Column("key3_col_desc")]
    [StringLength(30)]
    public string? Key3ColDesc { get; set; }

    [Column("key4_col_name")]
    [StringLength(64)]
    public string? Key4ColName { get; set; }

    [Column("key4_col_desc")]
    [StringLength(30)]
    public string? Key4ColDesc { get; set; }

    [Column("key5_col_name")]
    [StringLength(64)]
    public string? Key5ColName { get; set; }

    [Column("key5_col_desc")]
    [StringLength(30)]
    public string? Key5ColDesc { get; set; }

    [Column("desc1_col_name")]
    [StringLength(64)]
    public string? Desc1ColName { get; set; }

    [Column("desc1_col_desc")]
    [StringLength(30)]
    public string? Desc1ColDesc { get; set; }

    [Column("desc2_col_name")]
    [StringLength(64)]
    public string? Desc2ColName { get; set; }

    [Column("desc2_col_desc")]
    [StringLength(30)]
    public string? Desc2ColDesc { get; set; }

    [Column("upper_case_ind")]
    [StringLength(1)]
    public string? UpperCaseInd { get; set; }

    [Column("allow_del_cd_val")]
    [StringLength(1)]
    public string? AllowDelCdVal { get; set; }

    [Column("allow_mod_cd_val")]
    [StringLength(1)]
    public string? AllowModCdVal { get; set; }

    [Column("cd_val_min_len")]
    public int? CdValMinLen { get; set; }

    [Column("cd_val_max_len")]
    public int? CdValMaxLen { get; set; }

    [Column("cd_val_desc_min_len")]
    public int? CdValDescMinLen { get; set; }

    [Column("cd_val_desc_max_len")]
    public int? CdValDescMaxLen { get; set; }

    [Column("sql_where_clause")]
    public string? SqlWhereClause { get; set; }

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

    [InverseProperty("RefDef")]
    public virtual ICollection<CdTblVal> CdTblVal { get; set; } = new List<CdTblVal>();

    [InverseProperty("RefDef")]
    public virtual ICollection<RefXref> RefXrefRefDef { get; set; } = new List<RefXref>();

    [InverseProperty("RefDefNavigation")]
    public virtual ICollection<RefXref> RefXrefRefDefNavigation { get; set; } = new List<RefXref>();
}
