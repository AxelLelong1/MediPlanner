using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("impexp_tables")]
public partial class ImpexpTables
{
    [Key]
    [Column("table_name")]
    [StringLength(30)]
    public string TableName { get; set; } = null!;

    [Column("impexp_order")]
    public int? ImpexpOrder { get; set; }

    [Column("update_flag")]
    [StringLength(1)]
    public string? UpdateFlag { get; set; }

    [Column("tstamp_flag")]
    [StringLength(1)]
    public string? TstampFlag { get; set; }

    [Column("impexp_app_cd")]
    [StringLength(2)]
    public string? ImpexpAppCd { get; set; }

    [Column("table_columns")]
    public string? TableColumns { get; set; }

    [Column("distinct_ind")]
    [StringLength(1)]
    public string? DistinctInd { get; set; }

    [Column("impexp_cmt")]
    [StringLength(100)]
    public string? ImpexpCmt { get; set; }

    [Column("audit_ind")]
    [StringLength(1)]
    public string? AuditInd { get; set; }

    [Column("audit_table")]
    [StringLength(30)]
    public string? AuditTable { get; set; }

    [Column("event_id")]
    public int? EventId { get; set; }

    [Column("audit_indv_rows_ind")]
    [StringLength(1)]
    public string? AuditIndvRowsInd { get; set; }

    [Column("merge_cat")]
    public int? MergeCat { get; set; }

    [Column("merge_order")]
    public int? MergeOrder { get; set; }

    [Column("ccs_merge_cat")]
    public int? CcsMergeCat { get; set; }

    [Column("ccs_merge_order")]
    public int? CcsMergeOrder { get; set; }

    [InverseProperty("TableNameNavigation")]
    public virtual ICollection<ImpexpApp> ImpexpApp { get; set; } = new List<ImpexpApp>();

    [InverseProperty("TableNameNavigation")]
    public virtual ICollection<ImpexpColumns> ImpexpColumns { get; set; } = new List<ImpexpColumns>();

    [InverseProperty("ThruTableNavigation")]
    public virtual ICollection<ImpexpThru> ImpexpThru { get; set; } = new List<ImpexpThru>();

    [InverseProperty("TblNameNavigation")]
    public virtual TrfTblSendAll? TrfTblSendAll { get; set; }

    [InverseProperty("TblNameNavigation")]
    public virtual ICollection<TrfTblToBlock> TrfTblToBlock { get; set; } = new List<TrfTblToBlock>();
}
