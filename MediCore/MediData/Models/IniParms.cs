using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "SectName", "ParmName")]
[Table("ini_parms")]
public partial class IniParms
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("sect_name")]
    [StringLength(30)]
    public string SectName { get; set; } = null!;

    [Key]
    [Column("parm_name")]
    [StringLength(30)]
    public string ParmName { get; set; } = null!;

    [Column("parm_val")]
    [StringLength(255)]
    public string? ParmVal { get; set; }

    [Column("data_typ")]
    [StringLength(2)]
    public string? DataTyp { get; set; }

    [Column("enc_ind")]
    [StringLength(1)]
    public string? EncInd { get; set; }

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

    [Column("revision_no")]
    public int? RevisionNo { get; set; }

    [Column("tab_name")]
    [StringLength(256)]
    public string? TabName { get; set; }

    [Column("window_name")]
    [StringLength(256)]
    public string? WindowName { get; set; }
}
