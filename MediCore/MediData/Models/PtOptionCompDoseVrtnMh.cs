using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtOptionId", "OptionSeqNo", "DoseVrtnTyp", "RevisionNo")]
[Table("pt_option_comp_dose_vrtn_mh")]
public partial class PtOptionCompDoseVrtnMh
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_option_id")]
    public int PtOptionId { get; set; }

    [Key]
    [Column("option_seq_no")]
    public int OptionSeqNo { get; set; }

    [Key]
    [Column("dose_vrtn_typ")]
    public int DoseVrtnTyp { get; set; }

    [Key]
    [Column("revision_no")]
    public int RevisionNo { get; set; }

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
}
