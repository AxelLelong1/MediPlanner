using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "LocId")]
[Table("inst_loc")]
public partial class InstLoc
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("loc_id")]
    public int LocId { get; set; }

    [Column("loc_desc")]
    [StringLength(40)]
    public string LocDesc { get; set; } = null!;

    [Column("capacity")]
    public int? Capacity { get; set; }

    [Column("event_typ")]
    [StringLength(1)]
    public string? EventTyp { get; set; }

    [Column("primary_ind")]
    [StringLength(1)]
    public string? PrimaryInd { get; set; }

    [Column("active_entry_ind")]
    [StringLength(1)]
    public string? ActiveEntryInd { get; set; }

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

    [Column("slot_size")]
    public int? SlotSize { get; set; }

    [Column("dept_id")]
    public int? DeptId { get; set; }

    [Column("bldg_id")]
    public int? BldgId { get; set; }

    [Column("floor_id")]
    public int? FloorId { get; set; }

    [Column("room_id")]
    public int? RoomId { get; set; }

    [Column("outbnd_sch_ind")]
    [StringLength(1)]
    public string? OutbndSchInd { get; set; }

    [Column("loc_open_time")]
    [StringLength(4)]
    public string? LocOpenTime { get; set; }

    [Column("loc_close_time")]
    [StringLength(4)]
    public string? LocCloseTime { get; set; }

    [Column("intf_loc_map_name")]
    [StringLength(40)]
    public string? IntfLocMapName { get; set; }

    [Column("loc_cmt")]
    [StringLength(255)]
    public string? LocCmt { get; set; }

    [Column("overbook_cd")]
    [StringLength(1)]
    public string? OverbookCd { get; set; }

    [Column("loc_tel")]
    [StringLength(28)]
    public string? LocTel { get; set; }

    [Column("loc_tel_ext")]
    [StringLength(10)]
    public string? LocTelExt { get; set; }

    [Column("printable_ind")]
    [StringLength(1)]
    public string? PrintableInd { get; set; }

    [Column("loc_group_id")]
    public int? LocGroupId { get; set; }

    [Column("loc_tel_fmt_id")]
    public int? LocTelFmtId { get; set; }

    [Column("unavl_cmt")]
    [StringLength(200)]
    public string? UnavlCmt { get; set; }

    [ForeignKey("LocTelFmtId")]
    [InverseProperty("InstLoc")]
    public virtual FmtField? LocTelFmt { get; set; }

    [InverseProperty("InstLoc")]
    public virtual ICollection<XrefInstLocDispLoc> XrefInstLocDispLoc { get; set; } = new List<XrefInstLocDispLoc>();
}
