using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("hl7_seg_typ")]
public partial class Hl7SegTyp
{
    [Key]
    [Column("seg_typ_id")]
    [StringLength(10)]
    public string SegTypId { get; set; } = null!;

    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Column("def_typ")]
    [StringLength(1)]
    public string DefTyp { get; set; } = null!;

    [Column("seg_typ")]
    [StringLength(3)]
    public string SegTyp { get; set; } = null!;

    [Column("seg_typ_name")]
    [StringLength(30)]
    public string SegTypName { get; set; } = null!;

    [Column("seg_typ_desc")]
    [StringLength(255)]
    public string? SegTypDesc { get; set; }

    [Column("snapshot_ind")]
    [StringLength(1)]
    public string SnapshotInd { get; set; } = null!;

    [Column("vers_no")]
    [StringLength(10)]
    public string VersNo { get; set; } = null!;

    [Column("grp_ind")]
    [StringLength(1)]
    public string GrpInd { get; set; } = null!;

    [Column("del_ind")]
    [StringLength(1)]
    public string DelInd { get; set; } = null!;

    [Column("base_tstamp", TypeName = "datetime")]
    public DateTime BaseTstamp { get; set; }

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

    [InverseProperty("SegTyp")]
    public virtual ICollection<Hl7MsgEvntSegXref> Hl7MsgEvntSegXref { get; set; } = new List<Hl7MsgEvntSegXref>();

    [InverseProperty("SegTyp")]
    public virtual ICollection<Hl7SegFieldXref> Hl7SegFieldXref { get; set; } = new List<Hl7SegFieldXref>();

    [ForeignKey("DefTyp, VersNo")]
    [InverseProperty("Hl7SegTyp")]
    public virtual Hl7Vers Hl7Vers { get; set; } = null!;
}
