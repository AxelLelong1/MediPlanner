using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("pn_toolbar_fcn_typ")]
public partial class PnToolbarFcnTyp
{
    [Key]
    [Column("pn_toolbar_fcn_typ")]
    public int PnToolbarFcnTyp1 { get; set; }

    [Column("pn_toolbar_fcn_desc")]
    [StringLength(30)]
    public string PnToolbarFcnDesc { get; set; } = null!;

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

    [Column("cur_entry_ind")]
    [StringLength(1)]
    public string? CurEntryInd { get; set; }
}
