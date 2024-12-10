using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("AddressCd1", "StkhCd")]
[Table("address_cd")]
public partial class AddressCd
{
    [Key]
    [Column("address_cd")]
    [StringLength(2)]
    public string AddressCd1 { get; set; } = null!;

    [Key]
    [Column("stkh_cd")]
    [StringLength(1)]
    public string StkhCd { get; set; } = null!;

    [Column("address_cd_desc")]
    [StringLength(40)]
    public string AddressCdDesc { get; set; } = null!;

    [Column("dflt_ind")]
    [StringLength(1)]
    public string DfltInd { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string TransLogMuserid { get; set; } = null!;

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string TransLogMinstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [InverseProperty("AddressCdNavigation")]
    public virtual ICollection<StkhAddress> StkhAddress { get; set; } = new List<StkhAddress>();
}
