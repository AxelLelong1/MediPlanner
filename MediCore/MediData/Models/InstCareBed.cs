using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "CareUnitId", "BedId")]
[Table("inst_care_bed")]
public partial class InstCareBed
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("care_unit_id")]
    public int CareUnitId { get; set; }

    [Key]
    [Column("bed_id")]
    public int BedId { get; set; }

    [Column("room_desc")]
    [StringLength(10)]
    public string RoomDesc { get; set; } = null!;

    [Column("bed_desc")]
    [StringLength(10)]
    public string BedDesc { get; set; } = null!;

    [Column("medicare_ind")]
    [StringLength(1)]
    public string MedicareInd { get; set; } = null!;

    [Column("active_entry_ind")]
    [StringLength(1)]
    public string ActiveEntryInd { get; set; } = null!;

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

    [ForeignKey("InstId, CareUnitId")]
    [InverseProperty("InstCareBed")]
    public virtual InstCareUnit InstCareUnit { get; set; } = null!;

    [InverseProperty("InstCareBed")]
    public virtual ICollection<PtAdt> PtAdt { get; set; } = new List<PtAdt>();

    [InverseProperty("InstCareBed")]
    public virtual RoomBedUse? RoomBedUse { get; set; }
}
