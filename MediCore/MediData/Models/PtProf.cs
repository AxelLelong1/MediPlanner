using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "InstId", "UseridLink")]
[Table("pt_prof")]
[Index("InstId", "UseridLink", Name = "nc1_pt_prof")]
public partial class PtProf
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("userid_link")]
    [StringLength(255)]
    public string UseridLink { get; set; } = null!;

    [Column("prof_reltn")]
    public int ProfReltn { get; set; }

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

    [Column("stkh_conv_flag")]
    [StringLength(1)]
    public string? StkhConvFlag { get; set; }

    [ForeignKey("ProfReltn")]
    [InverseProperty("PtProf")]
    public virtual ProfReltn ProfReltnNavigation { get; set; } = null!;

    [ForeignKey("InstId, UseridLink")]
    [InverseProperty("PtProf")]
    public virtual Userid Userid { get; set; } = null!;
}
