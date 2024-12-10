using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("hl7_msg_evnt_xref")]
public partial class Hl7MsgEvntXref
{
    [Key]
    [Column("msg_evnt_xref_id")]
    [StringLength(10)]
    public string MsgEvntXrefId { get; set; } = null!;

    [Column("msg_typ_id")]
    [StringLength(10)]
    public string MsgTypId { get; set; } = null!;

    [Column("evnt_typ_id")]
    [StringLength(10)]
    public string EvntTypId { get; set; } = null!;

    [Column("default_ind")]
    [StringLength(1)]
    public string DefaultInd { get; set; } = null!;

    [Column("supported_ind")]
    [StringLength(1)]
    public string SupportedInd { get; set; } = null!;

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

    [ForeignKey("EvntTypId")]
    [InverseProperty("Hl7MsgEvntXref")]
    public virtual Hl7EvntTyp EvntTyp { get; set; } = null!;

    [InverseProperty("MsgEvntXref")]
    public virtual ICollection<Hl7MsgEvntSegXref> Hl7MsgEvntSegXref { get; set; } = new List<Hl7MsgEvntSegXref>();

    [ForeignKey("MsgTypId")]
    [InverseProperty("Hl7MsgEvntXref")]
    public virtual Hl7MsgTyp MsgTyp { get; set; } = null!;
}
