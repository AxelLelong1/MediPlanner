using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("pt_status_typ")]
public partial class PtStatusTyp
{
    [Key]
    [Column("pt_status_typ_id")]
    public int PtStatusTypId { get; set; }

    [Column("pt_status_typ_desc")]
    [StringLength(40)]
    public string PtStatusTypDesc { get; set; } = null!;

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

    [InverseProperty("PtStatusTyp")]
    public virtual ICollection<PtStatus> PtStatus { get; set; } = new List<PtStatus>();
}
