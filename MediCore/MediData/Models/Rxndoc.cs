using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("RXNDOC")]
public partial class Rxndoc
{
    [Key]
    [Column("RXNDOC_ID")]
    public int RxndocId { get; set; }

    [Column("DOCKEY")]
    [StringLength(50)]
    public string Dockey { get; set; } = null!;

    [Column("VALUE")]
    [StringLength(1000)]
    public string? Value { get; set; }

    [Column("TYPE")]
    [StringLength(50)]
    public string Type { get; set; } = null!;

    [Column("EXPL")]
    [StringLength(1000)]
    public string? Expl { get; set; }

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
}
