using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtAgendaHdrId")]
[Table("pt_agenda_hdr")]
public partial class PtAgendaHdr
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_agenda_hdr_id")]
    public int PtAgendaHdrId { get; set; }

    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Column("agenda_template_id")]
    public int AgendaTemplateId { get; set; }

    [Column("template_desc")]
    [StringLength(50)]
    public string TemplateDesc { get; set; } = null!;

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("date_of_service", TypeName = "datetime")]
    public DateTime? DateOfService { get; set; }

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

    [ForeignKey("InstId, AgendaTemplateId")]
    [InverseProperty("PtAgendaHdr")]
    public virtual AgendaTemplate AgendaTemplate { get; set; } = null!;

    [ForeignKey("PtId")]
    [InverseProperty("PtAgendaHdr")]
    public virtual Pt Pt { get; set; } = null!;

    [InverseProperty("PtAgendaHdr")]
    public virtual ICollection<PtAgenda> PtAgenda { get; set; } = new List<PtAgenda>();
}
