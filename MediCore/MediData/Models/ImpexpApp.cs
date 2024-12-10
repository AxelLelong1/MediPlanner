using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TableName", "ImpexpAppCd")]
[Table("impexp_app")]
public partial class ImpexpApp
{
    [Key]
    [Column("table_name")]
    [StringLength(30)]
    public string TableName { get; set; } = null!;

    [Key]
    [Column("impexp_app_cd")]
    [StringLength(2)]
    public string ImpexpAppCd { get; set; } = null!;

    [Column("impexp_app_cmt")]
    [StringLength(100)]
    public string? ImpexpAppCmt { get; set; }

    [Column("sync_tbl")]
    [StringLength(1)]
    public string? SyncTbl { get; set; }

    [ForeignKey("ImpexpAppCd")]
    [InverseProperty("ImpexpApp")]
    public virtual ImpexpAppTyp ImpexpAppCdNavigation { get; set; } = null!;

    [InverseProperty("ImpexpApp")]
    public virtual ICollection<ImpexpThru> ImpexpThru { get; set; } = new List<ImpexpThru>();

    [ForeignKey("TableName")]
    [InverseProperty("ImpexpApp")]
    public virtual ImpexpTables TableNameNavigation { get; set; } = null!;
}
