using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("hl7_msg_typ")]
public partial class Hl7MsgTyp
{
    [Key]
    [Column("msg_typ_id")]
    [StringLength(10)]
    public string MsgTypId { get; set; } = null!;

    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Column("def_typ")]
    [StringLength(1)]
    public string DefTyp { get; set; } = null!;

    [Column("msg_typ")]
    [StringLength(3)]
    public string MsgTyp { get; set; } = null!;

    [Column("vers_no")]
    [StringLength(10)]
    public string VersNo { get; set; } = null!;

    [Column("msg_typ_name")]
    [StringLength(30)]
    public string MsgTypName { get; set; } = null!;

    [Column("msg_typ_desc")]
    [StringLength(255)]
    public string? MsgTypDesc { get; set; }

    [Column("order_typ")]
    [StringLength(3)]
    public string? OrderTyp { get; set; }

    [Column("inbnd_ind")]
    [StringLength(1)]
    public string InbndInd { get; set; } = null!;

    [Column("outbnd_ind")]
    [StringLength(1)]
    public string OutbndInd { get; set; } = null!;

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

    [Column("master_file_typ")]
    [StringLength(5)]
    public string? MasterFileTyp { get; set; }

    [Column("msg_typ_status_cd")]
    [StringLength(1)]
    public string? MsgTypStatusCd { get; set; }

    [Column("msg_typ_level")]
    public int? MsgTypLevel { get; set; }

    [Column("sign_out_userid")]
    [StringLength(255)]
    public string? SignOutUserid { get; set; }

    [Column("sign_out_instid")]
    [StringLength(30)]
    public string? SignOutInstid { get; set; }

    [Column("sign_out_tstamp", TypeName = "datetime")]
    public DateTime? SignOutTstamp { get; set; }

    [InverseProperty("MsgTyp")]
    public virtual ICollection<Hl7MsgAppTypXref> Hl7MsgAppTypXref { get; set; } = new List<Hl7MsgAppTypXref>();

    [InverseProperty("MsgTyp")]
    public virtual ICollection<Hl7MsgEvntSegXref> Hl7MsgEvntSegXref { get; set; } = new List<Hl7MsgEvntSegXref>();

    [InverseProperty("MsgTyp")]
    public virtual ICollection<Hl7MsgEvntXref> Hl7MsgEvntXref { get; set; } = new List<Hl7MsgEvntXref>();

    [InverseProperty("MsgTyp")]
    public virtual ICollection<Hl7MsgTypAuditHist> Hl7MsgTypAuditHist { get; set; } = new List<Hl7MsgTypAuditHist>();

    [ForeignKey("DefTyp, VersNo")]
    [InverseProperty("Hl7MsgTyp")]
    public virtual Hl7Vers Hl7Vers { get; set; } = null!;
}
