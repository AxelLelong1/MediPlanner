using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("System", "Aspect", "AspectDesc1")]
[Table("aspect_desc")]
public partial class AspectDesc
{
    [Key]
    [Column("system")]
    [StringLength(30)]
    public string System { get; set; } = null!;

    [Key]
    [Column("aspect")]
    [StringLength(30)]
    public string Aspect { get; set; } = null!;

    [Key]
    [Column("aspect_desc")]
    [StringLength(100)]
    public string AspectDesc1 { get; set; } = null!;

    [Column("norm_dflt_ind")]
    [StringLength(1)]
    public string NormDfltInd { get; set; } = null!;

    [Column("abnorm_dflt_ind")]
    [StringLength(1)]
    public string AbnormDfltInd { get; set; } = null!;

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string ValidEntryInd { get; set; } = null!;

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
    public DateTime TransTrfTstamp { get; set; }

    [InverseProperty("AspectDescNavigation")]
    public virtual ICollection<AspectDescPhys> AspectDescPhys { get; set; } = new List<AspectDescPhys>();

    [ForeignKey("System, Aspect")]
    [InverseProperty("AspectDesc")]
    public virtual TrCompName TrCompName { get; set; } = null!;
}
