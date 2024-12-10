using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("iv_resp_typ")]
public partial class IvRespTyp
{
    [Key]
    [Column("iv_resp_typ")]
    public int IvRespTyp1 { get; set; }

    [Column("iv_resp_desc")]
    [StringLength(40)]
    public string IvRespDesc { get; set; } = null!;

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

    [InverseProperty("IvRespTyp")]
    public virtual ICollection<IvQstrCat> IvQstrCat { get; set; } = new List<IvQstrCat>();
}
