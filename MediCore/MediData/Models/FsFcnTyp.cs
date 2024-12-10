using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("fs_fcn_typ")]
public partial class FsFcnTyp
{
    [Key]
    [Column("fs_fcn_id")]
    public int FsFcnId { get; set; }

    [Column("fs_fcn_desc")]
    [StringLength(255)]
    public string FsFcnDesc { get; set; } = null!;

    [Column("fs_dflt_fcn_order_no")]
    public int FsDfltFcnOrderNo { get; set; }

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
