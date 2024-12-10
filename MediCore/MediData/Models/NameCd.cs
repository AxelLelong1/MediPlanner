using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("NameCd1", "StkhCd")]
[Table("name_cd")]
public partial class NameCd
{
    [Key]
    [Column("name_cd")]
    [StringLength(1)]
    public string NameCd1 { get; set; } = null!;

    [Key]
    [Column("stkh_cd")]
    [StringLength(1)]
    public string StkhCd { get; set; } = null!;

    [Column("name_cd_desc")]
    [StringLength(40)]
    public string NameCdDesc { get; set; } = null!;

    [Column("dflt_ind")]
    [StringLength(1)]
    public string DfltInd { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string TransLogMuserid { get; set; } = null!;

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string TransLogMinstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [InverseProperty("NameCdNavigation")]
    public virtual ICollection<PtName> PtName { get; set; } = new List<PtName>();

    [InverseProperty("NameCdNavigation")]
    public virtual ICollection<StkhName> StkhName { get; set; } = new List<StkhName>();
}
