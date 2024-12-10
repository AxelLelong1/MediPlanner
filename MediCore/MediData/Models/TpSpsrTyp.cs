using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("tp_spsr_typ")]
public partial class TpSpsrTyp
{
    [Key]
    [Column("spsr_typ_id")]
    public int SpsrTypId { get; set; }

    [Column("spsr_typ_desc")]
    [StringLength(20)]
    public string? SpsrTypDesc { get; set; }

    [Column("culture_cd")]
    [StringLength(10)]
    public string? CultureCd { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
