using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("hl7_msg_app_typ_xref")]
public partial class Hl7MsgAppTypXref
{
    [Key]
    [Column("msg_app_typ_xref_id")]
    [StringLength(10)]
    public string MsgAppTypXrefId { get; set; } = null!;

    [Column("msg_typ_id")]
    [StringLength(10)]
    public string MsgTypId { get; set; } = null!;

    [Column("app_cd")]
    [StringLength(10)]
    public string AppCd { get; set; } = null!;

    [Column("app_typ")]
    [StringLength(20)]
    public string AppTyp { get; set; } = null!;

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

    [ForeignKey("MsgTypId")]
    [InverseProperty("Hl7MsgAppTypXref")]
    public virtual Hl7MsgTyp MsgTyp { get; set; } = null!;
}
