using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("qm_event_code")]
public partial class QmEventCode
{
    [Key]
    [Column("qm_event_code_id")]
    public int QmEventCodeId { get; set; }

    [Column("cls_scheme_id")]
    public int ClsSchemeId { get; set; }

    [Column("qm_event_code_desc")]
    public string QmEventCodeDesc { get; set; } = null!;

    [Column("qm_event_code")]
    [StringLength(50)]
    public string QmEventCode1 { get; set; } = null!;

    [Column("active_entry_ind")]
    [StringLength(1)]
    public string ActiveEntryInd { get; set; } = null!;

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

    [ForeignKey("ClsSchemeId")]
    [InverseProperty("QmEventCode")]
    public virtual ClsScheme ClsScheme { get; set; } = null!;

    [InverseProperty("QmEventCode")]
    public virtual ICollection<PtQmEventCode> PtQmEventCode { get; set; } = new List<PtQmEventCode>();

    [InverseProperty("QmEventCode")]
    public virtual ICollection<QmEventCodeCulture> QmEventCodeCulture { get; set; } = new List<QmEventCodeCulture>();

    [InverseProperty("QmEventCode")]
    public virtual ICollection<QmEventCodeFavorite> QmEventCodeFavorite { get; set; } = new List<QmEventCodeFavorite>();

    [InverseProperty("QmEventCode")]
    public virtual ICollection<XrefQmValueSetEventCode> XrefQmValueSetEventCode { get; set; } = new List<XrefQmValueSetEventCode>();
}
