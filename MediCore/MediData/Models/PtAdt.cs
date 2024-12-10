using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtAdtId")]
[Table("pt_adt")]
public partial class PtAdt
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_adt_id")]
    public int PtAdtId { get; set; }

    [Column("pt_adt_tstamp", TypeName = "datetime")]
    public DateTime? PtAdtTstamp { get; set; }

    [Column("admit_cls")]
    public int? AdmitCls { get; set; }

    [Column("inst_id")]
    [StringLength(30)]
    public string? InstId { get; set; }

    [Column("care_unit_id")]
    public int? CareUnitId { get; set; }

    [Column("bed_id")]
    public int? BedId { get; set; }

    [Column("external_ind")]
    [StringLength(1)]
    public string? ExternalInd { get; set; }

    [Column("external_desc")]
    [StringLength(255)]
    public string? ExternalDesc { get; set; }

    [Column("ref_inst_id")]
    [StringLength(30)]
    public string? RefInstId { get; set; }

    [Column("ref_orgnztn_id")]
    public int? RefOrgnztnId { get; set; }

    [Column("adt_cmt")]
    [StringLength(255)]
    public string? AdtCmt { get; set; }

    [Column("adt_typ")]
    [StringLength(1)]
    public string? AdtTyp { get; set; }

    [Column("pgm_inst_id")]
    [StringLength(30)]
    public string? PgmInstId { get; set; }

    [Column("pgm_id")]
    public int? PgmId { get; set; }

    [Column("org_stkh_id")]
    [StringLength(20)]
    public string? OrgStkhId { get; set; }

    [Column("bed_desc")]
    [StringLength(16)]
    public string? BedDesc { get; set; }

    [Column("unit_desc")]
    [StringLength(16)]
    public string? UnitDesc { get; set; }

    [Column("room_desc")]
    [StringLength(16)]
    public string? RoomDesc { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string ValidEntryInd { get; set; } = null!;

    [Column("current_entry")]
    [StringLength(1)]
    public string CurrentEntry { get; set; } = null!;

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

    [ForeignKey("AdmitCls")]
    [InverseProperty("PtAdt")]
    public virtual AdmitCls? AdmitClsNavigation { get; set; }

    [ForeignKey("PgmInstId, PgmId")]
    [InverseProperty("PtAdt")]
    public virtual AdmitPgm? AdmitPgm { get; set; }

    [ForeignKey("InstId, CareUnitId, BedId")]
    [InverseProperty("PtAdt")]
    public virtual InstCareBed? InstCareBed { get; set; }

    [ForeignKey("OrgStkhId")]
    [InverseProperty("PtAdt")]
    public virtual Stkh? OrgStkh { get; set; }

    [InverseProperty("PtAdt")]
    public virtual ICollection<RoomBedUse> RoomBedUse { get; set; } = new List<RoomBedUse>();
}
