﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("bed_use_typ")]
public partial class BedUseTyp
{
    [Key]
    [Column("bed_use_typ")]
    public int BedUseTyp1 { get; set; }

    [Column("bed_use_typ_desc")]
    [StringLength(40)]
    public string BedUseTypDesc { get; set; } = null!;

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

    [InverseProperty("BedUseTypNavigation")]
    public virtual ICollection<RoomBedUse> RoomBedUse { get; set; } = new List<RoomBedUse>();
}