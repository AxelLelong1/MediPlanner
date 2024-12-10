using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "BldgId", "FloorId")]
[Table("inst_loc_floor")]
public partial class InstLocFloor
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("bldg_id")]
    public int BldgId { get; set; }

    [Key]
    [Column("floor_id")]
    public int FloorId { get; set; }

    [Column("floor_name")]
    [StringLength(30)]
    public string? FloorName { get; set; }

    [Column("floor_desc")]
    [StringLength(80)]
    public string? FloorDesc { get; set; }

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

    [ForeignKey("InstId, BldgId")]
    [InverseProperty("InstLocFloor")]
    public virtual InstLocBldg InstLocBldg { get; set; } = null!;

    [InverseProperty("InstLocFloor")]
    public virtual ICollection<InstLocRoom> InstLocRoom { get; set; } = new List<InstLocRoom>();
}
