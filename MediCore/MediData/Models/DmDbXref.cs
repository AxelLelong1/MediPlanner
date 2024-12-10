using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("CcsKeyId", "CcsSeqTyp", "CcsEnmValue", "CcsMedValue")]
[Table("dm_db_xref")]
public partial class DmDbXref
{
    [Key]
    [Column("ccs_key_id")]
    [StringLength(30)]
    public string CcsKeyId { get; set; } = null!;

    [Key]
    [Column("ccs_seq_typ")]
    [StringLength(30)]
    public string CcsSeqTyp { get; set; } = null!;

    [Key]
    [Column("ccs_enm_value")]
    [StringLength(30)]
    public string CcsEnmValue { get; set; } = null!;

    [Key]
    [Column("ccs_med_value")]
    [StringLength(30)]
    public string CcsMedValue { get; set; } = null!;
}
