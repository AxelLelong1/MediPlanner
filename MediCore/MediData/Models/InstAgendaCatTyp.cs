using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "CatNameTyp")]
[Table("inst_agenda_cat_typ")]
public partial class InstAgendaCatTyp
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("cat_name_typ")]
    public int CatNameTyp { get; set; }

    [Column("inst_cat_desc")]
    [StringLength(50)]
    public string? InstCatDesc { get; set; }

    [Column("inst_task_area_typ")]
    public int? InstTaskAreaTyp { get; set; }

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

    [ForeignKey("CatNameTyp")]
    [InverseProperty("InstAgendaCatTyp")]
    public virtual AgendaCatTyp CatNameTypNavigation { get; set; } = null!;

    [ForeignKey("InstId, InstTaskAreaTyp")]
    [InverseProperty("InstAgendaCatTyp")]
    public virtual InstTaskAreaTyp? InstTaskAreaTypNavigation { get; set; }
}
