﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("tr_cs_typ")]
public partial class TrCsTyp
{
    [Key]
    [Column("tr_cs_typ")]
    public int TrCsTyp1 { get; set; }

    [Column("tr_cs_desc")]
    [StringLength(40)]
    public string TrCsDesc { get; set; } = null!;

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

    [InverseProperty("TrCsTypNavigation")]
    public virtual ICollection<TrAsmt> TrAsmt { get; set; } = new List<TrAsmt>();
}
