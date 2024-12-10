using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("hl7_evnt_typ")]
public partial class Hl7EvntTyp
{
    [Key]
    [Column("evnt_typ_id")]
    [StringLength(10)]
    public string EvntTypId { get; set; } = null!;

    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Column("def_typ")]
    [StringLength(1)]
    public string DefTyp { get; set; } = null!;

    [Column("evnt_typ")]
    [StringLength(3)]
    public string EvntTyp { get; set; } = null!;

    [Column("vers_no")]
    [StringLength(10)]
    public string VersNo { get; set; } = null!;

    [Column("evnt_typ_name")]
    [StringLength(30)]
    public string? EvntTypName { get; set; }

    [Column("evnt_typ_desc")]
    [StringLength(255)]
    public string? EvntTypDesc { get; set; }

    [Column("inbnd_ind")]
    [StringLength(1)]
    public string InbndInd { get; set; } = null!;

    [Column("outbnd_ind")]
    [StringLength(1)]
    public string OutbndInd { get; set; } = null!;

    [Column("flip_ind")]
    [StringLength(1)]
    public string FlipInd { get; set; } = null!;

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

    [InverseProperty("EvntTyp")]
    public virtual ICollection<Hl7MsgEvntXref> Hl7MsgEvntXref { get; set; } = new List<Hl7MsgEvntXref>();

    [ForeignKey("DefTyp, VersNo")]
    [InverseProperty("Hl7EvntTyp")]
    public virtual Hl7Vers Hl7Vers { get; set; } = null!;
}
