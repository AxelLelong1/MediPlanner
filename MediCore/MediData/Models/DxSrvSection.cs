using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("dx_srv_section")]
public partial class DxSrvSection
{
    [Key]
    [Column("dss_id")]
    public int DssId { get; set; }

    [Column("dss_desc")]
    [StringLength(40)]
    public string DssDesc { get; set; } = null!;

    [Column("dss_cd")]
    [StringLength(5)]
    public string? DssCd { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [InverseProperty("Dss")]
    public virtual ICollection<TypOfTest> TypOfTest { get; set; } = new List<TypOfTest>();
}
