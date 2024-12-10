using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("typ_of_test")]
public partial class TypOfTest
{
    [Key]
    [Column("typ_of_test")]
    [StringLength(20)]
    public string TypOfTest1 { get; set; } = null!;

    [Column("form_no")]
    [StringLength(20)]
    public string FormNo { get; set; } = null!;

    [Column("dss_id")]
    public int? DssId { get; set; }

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

    [Column("test_cls")]
    [StringLength(30)]
    public string? TestCls { get; set; }

    [Column("typ_of_test_id")]
    public int? TypOfTestId { get; set; }

    [ForeignKey("DssId")]
    [InverseProperty("TypOfTest")]
    public virtual DxSrvSection? Dss { get; set; }

    [InverseProperty("TypOfTestNavigation")]
    public virtual ICollection<TestComp> TestComp { get; set; } = new List<TestComp>();
}
