﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("other_name_typ")]
public partial class OtherNameTyp
{
    [Key]
    [Column("other_name_typ")]
    public int OtherNameTyp1 { get; set; }

    [Column("other_name_desc")]
    [StringLength(40)]
    public string OtherNameDesc { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [InverseProperty("OtherNameTypNavigation")]
    public virtual ICollection<OtherName> OtherName { get; set; } = new List<OtherName>();
}
