using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("CatNameTyp", "CatStatus")]
[Table("agenda_status_typ")]
public partial class AgendaStatusTyp
{
    [Key]
    [Column("cat_name_typ")]
    public int CatNameTyp { get; set; }

    [Key]
    [Column("cat_status")]
    public int CatStatus { get; set; }

    [Column("cat_desc")]
    [StringLength(50)]
    public string CatDesc { get; set; } = null!;

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
