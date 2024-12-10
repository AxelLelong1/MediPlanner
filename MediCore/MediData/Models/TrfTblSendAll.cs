using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("trf_tbl_send_all")]
public partial class TrfTblSendAll
{
    [Key]
    [Column("tbl_name")]
    [StringLength(30)]
    public string TblName { get; set; } = null!;

    [Column("perm_flag")]
    [StringLength(1)]
    public string PermFlag { get; set; } = null!;

    [Column("cmt")]
    [StringLength(255)]
    public string? Cmt { get; set; }

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

    [ForeignKey("TblName")]
    [InverseProperty("TrfTblSendAll")]
    public virtual ImpexpTables TblNameNavigation { get; set; } = null!;
}
