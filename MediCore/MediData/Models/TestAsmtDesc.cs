using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("Userid", "InstId", "TypOfTest", "CompName", "CompAsmtDesc")]
[Table("test_asmt_desc")]
public partial class TestAsmtDesc
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
    [Column("typ_of_test")]
    [StringLength(20)]
    public string TypOfTest { get; set; } = null!;

    [Key]
    [Column("comp_name")]
    [StringLength(30)]
    public string CompName { get; set; } = null!;

    [Key]
    [Column("comp_asmt_desc")]
    [StringLength(50)]
    public string CompAsmtDesc { get; set; } = null!;

    [Column("comp_asmt_level")]
    public int CompAsmtLevel { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
