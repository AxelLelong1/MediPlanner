using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("MapTyp", "ARefId", "AInstId", "BRefId", "BInstId")]
[Table("intf_map")]
public partial class IntfMap
{
    [Key]
    [Column("map_typ")]
    [StringLength(6)]
    public string MapTyp { get; set; } = null!;

    [Key]
    [Column("a_ref_id")]
    [StringLength(15)]
    public string ARefId { get; set; } = null!;

    [Key]
    [Column("a_inst_id")]
    [StringLength(30)]
    public string AInstId { get; set; } = null!;

    [Key]
    [Column("b_ref_id")]
    [StringLength(15)]
    public string BRefId { get; set; } = null!;

    [Key]
    [Column("b_inst_id")]
    [StringLength(30)]
    public string BInstId { get; set; } = null!;

    [Column("optx_dflt_val")]
    [StringLength(60)]
    public string? OptxDfltVal { get; set; }

    [Column("extrnl_dflt_val")]
    [StringLength(60)]
    public string? ExtrnlDfltVal { get; set; }

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
}
