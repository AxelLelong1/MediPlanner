using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvPtInstKeyIncr
{
    [Column("ctrpt_id")]
    [StringLength(20)]
    public string CtrptId { get; set; } = null!;

    [Column("ctrinst_id")]
    [StringLength(30)]
    public string CtrinstId { get; set; } = null!;

    [Column("ctrpt_inst_key_id")]
    public int CtrptInstKeyId { get; set; }

    [Column("pt_key_cd")]
    public int PtKeyCd { get; set; }

    [StringLength(1)]
    public string CurrentValueIndicator { get; set; } = null!;

    [Column("pt_key_value")]
    [StringLength(25)]
    public string PtKeyValue { get; set; } = null!;

    [StringLength(1)]
    public string? ValidEntryIndicator { get; set; }
}
