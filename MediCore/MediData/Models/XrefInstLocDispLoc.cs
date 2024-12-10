using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "LocId", "DispLocId")]
[Table("xref_inst_loc_disp_loc")]
public partial class XrefInstLocDispLoc
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("loc_id")]
    public int LocId { get; set; }

    [Key]
    [Column("disp_loc_id")]
    public int DispLocId { get; set; }

    [Column("priority")]
    public int Priority { get; set; }

    [Column("active_entry_ind")]
    [StringLength(1)]
    public string? ActiveEntryInd { get; set; }

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

    [ForeignKey("DispLocId")]
    [InverseProperty("XrefInstLocDispLoc")]
    public virtual DispLoc DispLoc { get; set; } = null!;

    [ForeignKey("InstId, LocId")]
    [InverseProperty("XrefInstLocDispLoc")]
    public virtual InstLoc InstLoc { get; set; } = null!;
}
