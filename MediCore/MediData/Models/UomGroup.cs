using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("UomGroupId", "UomCatId", "UomGroupName")]
[Table("uom_group")]
public partial class UomGroup
{
    [Key]
    [Column("uom_group_id")]
    public int UomGroupId { get; set; }

    [Key]
    [Column("uom_cat_id")]
    public int UomCatId { get; set; }

    [Key]
    [Column("uom_group_name")]
    [StringLength(20)]
    public string UomGroupName { get; set; } = null!;

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
}
