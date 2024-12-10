using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("bill_cd_typ")]
public partial class BillCdTyp
{
    [Key]
    [Column("bill_cd_typ_id")]
    public int BillCdTypId { get; set; }

    [Column("bill_cd_typ_desc")]
    [StringLength(10)]
    public string BillCdTypDesc { get; set; } = null!;

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

    [InverseProperty("BillCdTyp")]
    public virtual ICollection<BillCd> BillCd { get; set; } = new List<BillCd>();

    [InverseProperty("BillCdTyp")]
    public virtual ICollection<BillEvent> BillEvent { get; set; } = new List<BillEvent>();
}
