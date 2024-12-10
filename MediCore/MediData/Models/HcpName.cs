using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("HcpInstId", "HcpId")]
[Table("hcp_name")]
public partial class HcpName
{
    [Key]
    [Column("hcp_inst_id")]
    [StringLength(30)]
    public string HcpInstId { get; set; } = null!;

    [Key]
    [Column("hcp_id")]
    public int HcpId { get; set; }

    [Column("hcp_name")]
    [StringLength(50)]
    public string HcpName1 { get; set; } = null!;

    [Column("upper_hcp_name")]
    [StringLength(50)]
    public string UpperHcpName { get; set; } = null!;

    [Column("hcp_typ")]
    public int HcpTyp { get; set; }

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

    [Column("active_entry_ind")]
    [StringLength(1)]
    public string? ActiveEntryInd { get; set; }

    [InverseProperty("HcpName")]
    public virtual ICollection<HcpBill> HcpBill { get; set; } = new List<HcpBill>();

    [InverseProperty("HcpNameNavigation")]
    public virtual ICollection<HcpRxProd> HcpRxProd { get; set; } = new List<HcpRxProd>();

    [ForeignKey("HcpTyp")]
    [InverseProperty("HcpName")]
    public virtual HcpTyp HcpTypNavigation { get; set; } = null!;
}
