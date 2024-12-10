using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("fcn_comp_typ")]
public partial class FcnCompTyp
{
    [Key]
    [Column("comp_name")]
    [StringLength(30)]
    public string CompName { get; set; } = null!;

    [Column("comp_alias_1")]
    [StringLength(30)]
    public string CompAlias1 { get; set; } = null!;

    [Column("comp_alias_2")]
    [StringLength(30)]
    public string CompAlias2 { get; set; } = null!;

    [Column("edit_ind")]
    [StringLength(1)]
    public string? EditInd { get; set; }

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

    [Column("comp_order_no")]
    public int? CompOrderNo { get; set; }

    [InverseProperty("CompNameNavigation")]
    public virtual ICollection<FcnComp> FcnComp { get; set; } = new List<FcnComp>();
}
