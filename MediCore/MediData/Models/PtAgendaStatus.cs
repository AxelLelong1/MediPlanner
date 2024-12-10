using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtVisitId", "CatName", "CatId")]
[Table("pt_agenda_status")]
[Index("PtId", "CatNameTyp", "CatId", Name = "nc1_pt_agenda_status")]
public partial class PtAgendaStatus
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Key]
    [Column("cat_name")]
    [StringLength(50)]
    public string CatName { get; set; } = null!;

    [Key]
    [Column("cat_id")]
    public int CatId { get; set; }

    [Column("cat_typ")]
    [StringLength(1)]
    public string CatTyp { get; set; } = null!;

    [Column("cat_status")]
    public int CatStatus { get; set; }

    [Column("cat_msg")]
    public string? CatMsg { get; set; }

    [Column("cat_name_typ")]
    public int? CatNameTyp { get; set; }

    [Column("cat_seq")]
    public int? CatSeq { get; set; }

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
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("review_tstamp", TypeName = "datetime")]
    public DateTime? ReviewTstamp { get; set; }

    [ForeignKey("PtId, PtVisitId")]
    [InverseProperty("PtAgendaStatus")]
    public virtual PtVisit PtVisit { get; set; } = null!;
}
