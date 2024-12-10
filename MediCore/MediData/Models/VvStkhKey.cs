using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvStkhKey
{
    [Column("key_value")]
    [StringLength(30)]
    public string KeyValue { get; set; } = null!;

    [StringLength(1)]
    public string CurrentValueIndicator { get; set; } = null!;

    [StringLength(1)]
    public string ValidEntryIndicator { get; set; } = null!;

    [Column("inst_label")]
    [StringLength(30)]
    public string InstLabel { get; set; } = null!;

    [StringLength(1)]
    public string ActiveIndicator { get; set; } = null!;

    [Column("ctrstkh_id")]
    [StringLength(20)]
    public string CtrstkhId { get; set; } = null!;

    [Column("ctrstkh_key_id")]
    public int CtrstkhKeyId { get; set; }

    [Column("ctrstkh_key_cd")]
    public int CtrstkhKeyCd { get; set; }

    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;
}
