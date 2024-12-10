using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("agenda_cat_typ")]
public partial class AgendaCatTyp
{
    [Key]
    [Column("cat_name_typ")]
    public int CatNameTyp { get; set; }

    [Column("cat_desc")]
    [StringLength(50)]
    public string CatDesc { get; set; } = null!;

    [Column("cat_seq")]
    public int? CatSeq { get; set; }

    [Column("visible_ind")]
    [StringLength(1)]
    public string? VisibleInd { get; set; }

    [Column("cust_cat_ind")]
    [StringLength(1)]
    public string? CustCatInd { get; set; }

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

    [Column("task_area_typ")]
    public int? TaskAreaTyp { get; set; }

    [Column("cat_typ")]
    [StringLength(1)]
    public string? CatTyp { get; set; }

    [Column("agenda_init_ind")]
    [StringLength(1)]
    public string? AgendaInitInd { get; set; }

    [Column("permit_del_ind")]
    [StringLength(1)]
    public string? PermitDelInd { get; set; }

    [Column("task_ind")]
    [StringLength(1)]
    public string? TaskInd { get; set; }

    [Column("visible_req_ind")]
    [StringLength(1)]
    public string? VisibleReqInd { get; set; }

    [InverseProperty("CatNameTypNavigation")]
    public virtual ICollection<InstAgendaCatTyp> InstAgendaCatTyp { get; set; } = new List<InstAgendaCatTyp>();

    [InverseProperty("CatNameTypNavigation")]
    public virtual ICollection<TaskFcnUser> TaskFcnUser { get; set; } = new List<TaskFcnUser>();

    [InverseProperty("CatNameTypNavigation")]
    public virtual ICollection<VisitTask> VisitTask { get; set; } = new List<VisitTask>();
}
