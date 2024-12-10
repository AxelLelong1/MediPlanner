using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtListQueryCriteriaId", "CriteriaValueTyp")]
[Table("pt_list_query_criteria_value")]
public partial class PtListQueryCriteriaValue
{
    [Key]
    [Column("pt_list_query_criteria_id")]
    public int PtListQueryCriteriaId { get; set; }

    [Key]
    [Column("criteria_value_typ")]
    public int CriteriaValueTyp { get; set; }

    [Column("criteria_value")]
    [StringLength(150)]
    public string CriteriaValue { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [ForeignKey("PtListQueryCriteriaId")]
    [InverseProperty("PtListQueryCriteriaValue")]
    public virtual PtListQueryCriteria PtListQueryCriteria { get; set; } = null!;
}
