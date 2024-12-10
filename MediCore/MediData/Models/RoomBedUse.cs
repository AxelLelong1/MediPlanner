using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "CareUnitId", "RoomBedId")]
[Table("room_bed_use")]
public partial class RoomBedUse
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("care_unit_id")]
    public int CareUnitId { get; set; }

    [Key]
    [Column("room_bed_id")]
    public int RoomBedId { get; set; }

    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }

    [Column("pt_adt_id")]
    public int? PtAdtId { get; set; }

    [Column("bed_use_typ")]
    public int BedUseTyp { get; set; }

    [Column("use_cmt")]
    [StringLength(255)]
    public string? UseCmt { get; set; }

    [Column("bed_hold_days")]
    public int? BedHoldDays { get; set; }

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

    [ForeignKey("BedUseTyp")]
    [InverseProperty("RoomBedUse")]
    public virtual BedUseTyp BedUseTypNavigation { get; set; } = null!;

    [ForeignKey("InstId, CareUnitId, RoomBedId")]
    [InverseProperty("RoomBedUse")]
    public virtual InstCareBed InstCareBed { get; set; } = null!;

    [ForeignKey("PtId, PtAdtId")]
    [InverseProperty("RoomBedUse")]
    public virtual PtAdt? PtAdt { get; set; }
}
