using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("impexp_app_typ")]
public partial class ImpexpAppTyp
{
    [Key]
    [Column("impexp_app_cd")]
    [StringLength(2)]
    public string ImpexpAppCd { get; set; } = null!;

    [Column("app_cd_desc")]
    [StringLength(60)]
    public string AppCdDesc { get; set; } = null!;

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

    [InverseProperty("ImpexpAppCdNavigation")]
    public virtual ICollection<ImpexpApp> ImpexpApp { get; set; } = new List<ImpexpApp>();
}
