﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("source_typ")]
public partial class SourceTyp
{
    [Key]
    [Column("source_typ")]
    public int SourceTyp1 { get; set; }

    [Column("source_desc")]
    [StringLength(40)]
    public string SourceDesc { get; set; } = null!;

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
