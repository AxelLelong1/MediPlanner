using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TypOfTest", "CompName")]
[Table("test_comp")]
public partial class TestComp
{
    [Key]
    [Column("typ_of_test")]
    [StringLength(20)]
    public string TypOfTest { get; set; } = null!;

    [Key]
    [Column("comp_name")]
    [StringLength(30)]
    public string CompName { get; set; } = null!;

    [Column("comp_order_no")]
    public int? CompOrderNo { get; set; }

    [Column("comp_typ")]
    public int CompTyp { get; set; }

    [Column("test_group")]
    [StringLength(20)]
    public string? TestGroup { get; set; }

    [Column("group_only_ind")]
    [StringLength(1)]
    public string? GroupOnlyInd { get; set; }

    [Column("status_typ")]
    public int? StatusTyp { get; set; }

    [Column("uom_req_ind")]
    [StringLength(1)]
    public string? UomReqInd { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

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

    [Column("sex_cd")]
    [StringLength(1)]
    public string? SexCd { get; set; }

    [Column("loinc_cd")]
    [StringLength(10)]
    public string? LoincCd { get; set; }

    [ForeignKey("CompTyp")]
    [InverseProperty("TestComp")]
    public virtual CompTyp CompTypNavigation { get; set; } = null!;

    [InverseProperty("TestComp")]
    public virtual ICollection<InstTestComp> InstTestComp { get; set; } = new List<InstTestComp>();

    [ForeignKey("StatusTyp")]
    [InverseProperty("TestComp")]
    public virtual StatusTyp? StatusTypNavigation { get; set; }

    [InverseProperty("TestComp")]
    public virtual ICollection<TrTypComp> TrTypComp { get; set; } = new List<TrTypComp>();

    [ForeignKey("TypOfTest")]
    [InverseProperty("TestComp")]
    public virtual TypOfTest TypOfTestNavigation { get; set; } = null!;

    [InverseProperty("TestComp")]
    public virtual ICollection<XrefSiteTest> XrefSiteTest { get; set; } = new List<XrefSiteTest>();

    [InverseProperty("TestComp")]
    public virtual ICollection<XrefTestCompCpt> XrefTestCompCpt { get; set; } = new List<XrefTestCompCpt>();
}
