using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("agt_grp_agt")]
public partial class AgtGrpAgt
{
    [Key]
    [Column("agt_grp_agt_id")]
    public int AgtGrpAgtId { get; set; }

    [Column("agt_grp_id")]
    public int AgtGrpId { get; set; }

    [Column("agt_name")]
    [StringLength(50)]
    public string AgtName { get; set; } = null!;

    [Column("dosage_form")]
    public int? DosageForm { get; set; }

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

    [Column("comp_seq_no")]
    public int? CompSeqNo { get; set; }
}
