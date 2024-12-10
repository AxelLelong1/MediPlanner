using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtIndHxId")]
[Table("pt_ind_hx")]
public partial class PtIndHx
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_ind_hx_id")]
    public int PtIndHxId { get; set; }

    [Column("pt_ind_typ")]
    public int PtIndTyp { get; set; }

    [Column("pt_ind_value")]
    [StringLength(1)]
    public string PtIndValue { get; set; } = null!;

    [Column("pt_ind_hx_date", TypeName = "datetime")]
    public DateTime PtIndHxDate { get; set; }

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
}
