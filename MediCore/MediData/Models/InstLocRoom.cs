using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "RoomId", "BldgId", "FloorId")]
[Table("inst_loc_room")]
public partial class InstLocRoom
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

    [Key]
    [Column("room_id")]
    public int RoomId { get; set; }

    [Column("room_name")]
    [StringLength(30)]
    public string? RoomName { get; set; }

    [Column("room_desc")]
    [StringLength(80)]
    public string? RoomDesc { get; set; }

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

    [ForeignKey("InstId, BldgId, FloorId")]
    [InverseProperty("InstLocRoom")]
    public virtual InstLocFloor InstLocFloor { get; set; } = null!;
}
