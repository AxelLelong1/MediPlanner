using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("BillModifierCd", "BillCdTypId")]
[Table("bill_modifier_typ")]
public partial class BillModifierTyp
{
    [Key]
    [Column("bill_cd_typ_id")]
    public int BillCdTypId { get; set; }

    [Key]
    [Column("bill_modifier_cd")]
    [StringLength(5)]
    public string BillModifierCd { get; set; } = null!;

    [Column("bill_modifier_desc")]
    [StringLength(255)]
    public string BillModifierDesc { get; set; } = null!;

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
}
