﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("HcpInstId", "HcpId", "BillCd", "BillCdTypId", "BillInstanceId")]
[Table("hcp_bill")]
public partial class HcpBill
{
    [Key]
    [Column("hcp_inst_id")]
    [StringLength(30)]
    public string HcpInstId { get; set; } = null!;

    [Key]
    [Column("hcp_id")]
    public int HcpId { get; set; }

    [Key]
    [Column("bill_cd")]
    [StringLength(30)]
    public string BillCd { get; set; } = null!;

    [Key]
    [Column("bill_cd_typ_id")]
    public int BillCdTypId { get; set; }

    [Key]
    [Column("bill_instance_id")]
    public int BillInstanceId { get; set; }

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

    [ForeignKey("BillCd, BillCdTypId, BillInstanceId")]
    [InverseProperty("HcpBill")]
    public virtual BillCdInstance BillCdInstance { get; set; } = null!;

    [ForeignKey("HcpInstId, HcpId")]
    [InverseProperty("HcpBill")]
    public virtual HcpName HcpName { get; set; } = null!;
}