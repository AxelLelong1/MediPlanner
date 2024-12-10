using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("hl7_msg_evnt_seg_xref")]
public partial class Hl7MsgEvntSegXref
{
    [Key]
    [Column("msg_evnt_seg_xref_id")]
    [StringLength(10)]
    public string MsgEvntSegXrefId { get; set; } = null!;

    [Column("msg_evnt_xref_id")]
    [StringLength(10)]
    public string MsgEvntXrefId { get; set; } = null!;

    [Column("msg_typ_id")]
    [StringLength(10)]
    public string MsgTypId { get; set; } = null!;

    [Column("seg_typ_id")]
    [StringLength(10)]
    public string SegTypId { get; set; } = null!;

    [Column("req_ind")]
    [StringLength(1)]
    public string ReqInd { get; set; } = null!;

    [Column("default_ind")]
    [StringLength(1)]
    public string DefaultInd { get; set; } = null!;

    [Column("sort_order_no")]
    public int SortOrderNo { get; set; }

    [Column("nte_assoc_ind")]
    [StringLength(1)]
    public string NteAssocInd { get; set; } = null!;

    [Column("grp_ind")]
    [StringLength(1)]
    public string GrpInd { get; set; } = null!;

    [Column("grp_child_ind")]
    [StringLength(1)]
    public string GrpChildInd { get; set; } = null!;

    [Column("repeatable_ind")]
    [StringLength(1)]
    public string RepeatableInd { get; set; } = null!;

    [Column("level_no")]
    public int LevelNo { get; set; }

    [Column("parent_msg_seg_xref_id")]
    [StringLength(10)]
    public string ParentMsgSegXrefId { get; set; } = null!;

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

    [InverseProperty("MsgEvntSegXref")]
    public virtual ICollection<Hl7MsgEvntSegFieldXref> Hl7MsgEvntSegFieldXref { get; set; } = new List<Hl7MsgEvntSegFieldXref>();

    [ForeignKey("MsgEvntXrefId")]
    [InverseProperty("Hl7MsgEvntSegXref")]
    public virtual Hl7MsgEvntXref MsgEvntXref { get; set; } = null!;

    [ForeignKey("MsgTypId")]
    [InverseProperty("Hl7MsgEvntSegXref")]
    public virtual Hl7MsgTyp MsgTyp { get; set; } = null!;

    [ForeignKey("SegTypId")]
    [InverseProperty("Hl7MsgEvntSegXref")]
    public virtual Hl7SegTyp SegTyp { get; set; } = null!;
}
