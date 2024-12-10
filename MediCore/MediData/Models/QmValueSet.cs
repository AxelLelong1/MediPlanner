using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("qm_value_set")]
public partial class QmValueSet
{
    [Key]
    [Column("qm_value_set_id")]
    public int QmValueSetId { get; set; }

    [Column("qm_value_set_desc")]
    public string QmValueSetDesc { get; set; } = null!;

    [Column("qm_value_set_code")]
    [StringLength(255)]
    public string QmValueSetCode { get; set; } = null!;

    [Column("qm_value_set_typ_id")]
    public int QmValueSetTypId { get; set; }

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

    [InverseProperty("NotDoneQmValueSet")]
    public virtual ICollection<QmEventCodeFavorite> QmEventCodeFavorite { get; set; } = new List<QmEventCodeFavorite>();

    [InverseProperty("QmRsnNotDoneValueSetNavigation")]
    public virtual ICollection<QmRsnNotDoneValueSet> QmRsnNotDoneValueSetQmRsnNotDoneValueSetNavigation { get; set; } = new List<QmRsnNotDoneValueSet>();

    [InverseProperty("QmValueSet")]
    public virtual ICollection<QmRsnNotDoneValueSet> QmRsnNotDoneValueSetQmValueSet { get; set; } = new List<QmRsnNotDoneValueSet>();

    [InverseProperty("QmValueSet")]
    public virtual ICollection<QmValueSetCulture> QmValueSetCulture { get; set; } = new List<QmValueSetCulture>();

    [InverseProperty("QmValueSet")]
    public virtual ICollection<XrefQmValueSetEventCode> XrefQmValueSetEventCode { get; set; } = new List<XrefQmValueSetEventCode>();

    [InverseProperty("QmValueSet")]
    public virtual ICollection<XrefQmValueSetQm> XrefQmValueSetQm { get; set; } = new List<XrefQmValueSetQm>();
}
