using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtVisitId", "RemSeqNo", "RemRcpntId")]
[Table("rem_rcpnt")]
public partial class RemRcpnt
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Key]
    [Column("rem_seq_no")]
    public int RemSeqNo { get; set; }

    [Key]
    [Column("rem_rcpnt_id")]
    public int RemRcpntId { get; set; }

    [Column("rcpnt_userid")]
    [StringLength(255)]
    public string? RcpntUserid { get; set; }

    [Column("rcpnt_user_inst_id")]
    [StringLength(30)]
    public string RcpntUserInstId { get; set; } = null!;

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

    [ForeignKey("PtId, PtVisitId, RemSeqNo")]
    [InverseProperty("RemRcpnt")]
    public virtual Rem Rem { get; set; } = null!;
}
