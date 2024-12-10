using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("impexp_thru")]
public partial class ImpexpThru
{
    [Column("table_name")]
    [StringLength(30)]
    public string TableName { get; set; } = null!;

    [Column("thru_table")]
    [StringLength(30)]
    public string ThruTable { get; set; } = null!;

    [Column("sql_join")]
    public string SqlJoin { get; set; } = null!;

    [Key]
    [Column("dumb_key")]
    public int DumbKey { get; set; }

    [Column("impexp_app_cd")]
    [StringLength(2)]
    public string ImpexpAppCd { get; set; } = null!;

    [ForeignKey("TableName, ImpexpAppCd")]
    [InverseProperty("ImpexpThru")]
    public virtual ImpexpApp ImpexpApp { get; set; } = null!;

    [ForeignKey("ThruTable")]
    [InverseProperty("ImpexpThru")]
    public virtual ImpexpTables ThruTableNavigation { get; set; } = null!;
}
