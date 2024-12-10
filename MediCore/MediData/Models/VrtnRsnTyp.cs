using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("FcnAreaTyp", "VrtnTyp", "VrtnRsnTyp1")]
[Table("vrtn_rsn_typ")]
public partial class VrtnRsnTyp
{
    [Key]
    [Column("fcn_area_typ")]
    public int FcnAreaTyp { get; set; }

    [Key]
    [Column("vrtn_typ")]
    public int VrtnTyp { get; set; }

    [Key]
    [Column("vrtn_rsn_typ")]
    public int VrtnRsnTyp1 { get; set; }

    [Column("vrtn_rsn_sort_no")]
    public int VrtnRsnSortNo { get; set; }

    [Column("vrtn_rsn_desc")]
    [StringLength(255)]
    public string VrtnRsnDesc { get; set; } = null!;

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string ValidEntryInd { get; set; } = null!;

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

    [ForeignKey("FcnAreaTyp, VrtnTyp")]
    [InverseProperty("VrtnRsnTyp")]
    public virtual VrtnTyp VrtnTypNavigation { get; set; } = null!;
}
