using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "FacInstId", "FacId", "FacRqstnNo")]
[Table("xref_inst_rqstn")]
public partial class XrefInstRqstn
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("fac_inst_id")]
    [StringLength(30)]
    public string FacInstId { get; set; } = null!;

    [Key]
    [Column("fac_id")]
    public int FacId { get; set; }

    [Key]
    [Column("fac_rqstn_no")]
    [StringLength(20)]
    public string FacRqstnNo { get; set; } = null!;

    [Column("prty_of_rqstn")]
    public int PrtyOfRqstn { get; set; }

    [Column("intf_unsol_ind")]
    [StringLength(1)]
    public string IntfUnsolInd { get; set; } = null!;

    [Column("elctrnc_transfer")]
    [StringLength(1)]
    public string? ElctrncTransfer { get; set; }

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

    [ForeignKey("FacInstId, FacId, FacRqstnNo")]
    [InverseProperty("XrefInstRqstn")]
    public virtual FacRqstn FacRqstn { get; set; } = null!;

    [ForeignKey("InstId")]
    [InverseProperty("XrefInstRqstn")]
    public virtual Inst Inst { get; set; } = null!;
}
