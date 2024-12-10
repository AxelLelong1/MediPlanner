using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "UserInstId", "Userid")]
[Table("inst_provider")]
[Index("UserInstId", "Userid", Name = "nc1_inst_provider")]
public partial class InstProvider
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("user_inst_id")]
    [StringLength(30)]
    public string UserInstId { get; set; } = null!;

    [Key]
    [Column("userid")]
    [StringLength(255)]
    public string Userid { get; set; } = null!;

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

    [Column("agt_formulary_group_inst_id")]
    [StringLength(30)]
    public string? AgtFormularyGroupInstId { get; set; }

    [Column("agt_formulary_group_id")]
    public int? AgtFormularyGroupId { get; set; }

    [Column("loc_id")]
    public int? LocId { get; set; }

    [Column("event_typ")]
    [StringLength(1)]
    public string? EventTyp { get; set; }

    [Column("unavl_cmt")]
    [StringLength(200)]
    public string? UnavlCmt { get; set; }

    [ForeignKey("AgtFormularyGroupInstId, AgtFormularyGroupId")]
    [InverseProperty("InstProvider")]
    public virtual AgtFormularyGroup? AgtFormularyGroup { get; set; }
}
