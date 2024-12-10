using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TableName", "ColumnName")]
[Table("impexp_columns")]
public partial class ImpexpColumns
{
    [Key]
    [Column("table_name")]
    [StringLength(30)]
    public string TableName { get; set; } = null!;

    [Key]
    [Column("column_name")]
    [StringLength(40)]
    public string ColumnName { get; set; } = null!;

    [Column("column_typ")]
    [StringLength(20)]
    public string ColumnTyp { get; set; } = null!;

    [Column("column_width")]
    public int ColumnWidth { get; set; }

    [Column("column_dflt")]
    public string? ColumnDflt { get; set; }

    [Column("is_empty_chk_flag")]
    [StringLength(1)]
    public string? IsEmptyChkFlag { get; set; }

    [Column("column_pkey_ind")]
    [StringLength(1)]
    public string? ColumnPkeyInd { get; set; }

    [Column("not_null_ind")]
    [StringLength(1)]
    public string? NotNullInd { get; set; }

    [Column("allow_col_to_trf")]
    [StringLength(1)]
    public string? AllowColToTrf { get; set; }

    [Column("data_elmnt_name")]
    [StringLength(30)]
    public string? DataElmntName { get; set; }

    [Column("scrub_rule")]
    [StringLength(30)]
    public string? ScrubRule { get; set; }

    [Column("column_audit_desc_ind")]
    [StringLength(1)]
    public string? ColumnAuditDescInd { get; set; }

    [Column("column_audit_desc_seq_no", TypeName = "numeric(5, 0)")]
    public decimal? ColumnAuditDescSeqNo { get; set; }

    [Column("column_pkey_seq_no", TypeName = "numeric(5, 0)")]
    public decimal? ColumnPkeySeqNo { get; set; }

    [Column("column_audit_dsp_value")]
    [StringLength(1)]
    public string? ColumnAuditDspValue { get; set; }

    [Column("uow_key_ind")]
    [StringLength(1)]
    public string? UowKeyInd { get; set; }

    [Column("uow_key_seq_no", TypeName = "numeric(5, 0)")]
    public decimal? UowKeySeqNo { get; set; }

    [Column("column_audit_value_ind")]
    [StringLength(1)]
    public string? ColumnAuditValueInd { get; set; }

    [Column("merge_id_ind")]
    [StringLength(1)]
    public string? MergeIdInd { get; set; }

    [Column("seq_typ")]
    [StringLength(40)]
    public string? SeqTyp { get; set; }

    [ForeignKey("ScrubRule")]
    [InverseProperty("ImpexpColumns")]
    public virtual TrfScrubRule? ScrubRuleNavigation { get; set; }

    [ForeignKey("TableName")]
    [InverseProperty("ImpexpColumns")]
    public virtual ImpexpTables TableNameNavigation { get; set; } = null!;

    [InverseProperty("ImpexpColumns")]
    public virtual ICollection<TrfColToOvride> TrfColToOvride { get; set; } = new List<TrfColToOvride>();
}
