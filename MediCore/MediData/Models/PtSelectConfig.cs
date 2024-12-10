using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("pt_select_config")]
public partial class PtSelectConfig
{
    [Key]
    [Column("pt_select_config_id")]
    public int PtSelectConfigId { get; set; }

    [Column("collapse_hl7_row_ind")]
    [StringLength(1)]
    public string CollapseHl7RowInd { get; set; } = null!;

    [Column("pt_submit_all_ind")]
    [StringLength(1)]
    public string PtSubmitAllInd { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
