using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtListQueryId", "BaseTypId", "InstId")]
[Table("base_typ_pt_list_query_xref")]
public partial class BaseTypPtListQueryXref
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("base_typ_id")]
    public int BaseTypId { get; set; }

    [Key]
    [Column("pt_list_query_id")]
    public int PtListQueryId { get; set; }

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

    [ForeignKey("InstId, BaseTypId")]
    [InverseProperty("BaseTypPtListQueryXref")]
    public virtual InstBaseTyp InstBaseTyp { get; set; } = null!;

    [ForeignKey("PtListQueryId")]
    [InverseProperty("BaseTypPtListQueryXref")]
    public virtual PtListQuery PtListQuery { get; set; } = null!;
}
