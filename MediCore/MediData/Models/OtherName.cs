using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("AgtName", "OtherName1")]
[Table("other_name")]
[Index("UpperAgtName", Name = "nc1_other_name")]
public partial class OtherName
{
    [Key]
    [Column("agt_name")]
    [StringLength(50)]
    public string AgtName { get; set; } = null!;

    [Key]
    [Column("other_name")]
    [StringLength(50)]
    public string OtherName1 { get; set; } = null!;

    [Column("other_name_typ")]
    public int? OtherNameTyp { get; set; }

    [Column("mfg_name")]
    [StringLength(30)]
    public string? MfgName { get; set; }

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

    [Column("upper_agt_name")]
    [StringLength(50)]
    public string? UpperAgtName { get; set; }

    [ForeignKey("AgtName")]
    [InverseProperty("OtherName")]
    public virtual AgtName AgtNameNavigation { get; set; } = null!;

    [ForeignKey("OtherNameTyp")]
    [InverseProperty("OtherName")]
    public virtual OtherNameTyp? OtherNameTypNavigation { get; set; }
}
