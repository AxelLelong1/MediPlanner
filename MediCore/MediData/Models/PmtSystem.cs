using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("pmt_system")]
public partial class PmtSystem
{
    [Key]
    [Column("pmt_system_id")]
    public int PmtSystemId { get; set; }

    [Column("pmt_system_desc")]
    [StringLength(30)]
    public string PmtSystemDesc { get; set; } = null!;

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

    [InverseProperty("PmtSystem")]
    public virtual ICollection<Financial> Financial { get; set; } = new List<Financial>();
}
