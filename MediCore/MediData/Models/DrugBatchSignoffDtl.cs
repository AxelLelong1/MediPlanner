using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "SignoffSectId", "SignoffDtlId")]
[Table("drug_batch_signoff_dtl")]
public partial class DrugBatchSignoffDtl
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("signoff_sect_id")]
    public int SignoffSectId { get; set; }

    [Key]
    [Column("signoff_dtl_id")]
    public int SignoffDtlId { get; set; }

    [Column("signoff_dtl_hdr_desc")]
    [StringLength(255)]
    public string? SignoffDtlHdrDesc { get; set; }

    [Column("signoff_dtl_desc")]
    public string? SignoffDtlDesc { get; set; }

    [Column("signoff_personnel")]
    [StringLength(255)]
    public string? SignoffPersonnel { get; set; }

    [Column("signoff_req_ind")]
    [StringLength(1)]
    public string? SignoffReqInd { get; set; }

    [Column("wrksht_include_ind")]
    [StringLength(1)]
    public string? WrkshtIncludeInd { get; set; }

    [Column("dtl_seq_no")]
    public int? DtlSeqNo { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [ForeignKey("InstId, SignoffSectId")]
    [InverseProperty("DrugBatchSignoffDtl")]
    public virtual DrugBatchSignoffSect DrugBatchSignoffSect { get; set; } = null!;
}
