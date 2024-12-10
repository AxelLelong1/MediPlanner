using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("Userid", "InstId", "TpClsTypId", "TpClsValueId", "TypOfTest", "CompName")]
[Table("xref_site_test")]
public partial class XrefSiteTest
{
    [Key]
    [Column("userid")]
    [StringLength(255)]
    public string Userid { get; set; } = null!;

    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("tp_cls_typ_id")]
    public int TpClsTypId { get; set; }

    [Key]
    [Column("tp_cls_value_id")]
    public int TpClsValueId { get; set; }

    [Key]
    [Column("typ_of_test")]
    [StringLength(20)]
    public string TypOfTest { get; set; } = null!;

    [Key]
    [Column("comp_name")]
    [StringLength(30)]
    public string CompName { get; set; } = null!;

    [Column("aspect_name")]
    [StringLength(30)]
    public string? AspectName { get; set; }

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

    [ForeignKey("TypOfTest, CompName")]
    [InverseProperty("XrefSiteTest")]
    public virtual TestComp TestComp { get; set; } = null!;

    [ForeignKey("TpClsTypId, TpClsValueId")]
    [InverseProperty("XrefSiteTest")]
    public virtual TpClsValue TpClsValue { get; set; } = null!;
}
