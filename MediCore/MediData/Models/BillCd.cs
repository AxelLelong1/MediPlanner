using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("BillCd1", "BillCdTypId")]
[Table("bill_cd")]
public partial class BillCd
{
    [Key]
    [Column("bill_cd")]
    [StringLength(30)]
    public string BillCd1 { get; set; } = null!;

    [Key]
    [Column("bill_cd_typ_id")]
    public int BillCdTypId { get; set; }

    [Column("bill_cd_desc")]
    [StringLength(250)]
    public string BillCdDesc { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("active_ind")]
    [StringLength(1)]
    public string? ActiveInd { get; set; }

    [Column("active_chg_date", TypeName = "datetime")]
    public DateTime? ActiveChgDate { get; set; }

    [Column("intf_send_bill_desc_ind")]
    [StringLength(1)]
    public string? IntfSendBillDescInd { get; set; }

    [Column("msg_typ_status_cd")]
    [StringLength(1)]
    public string? MsgTypStatusCd { get; set; }

    [Column("msg_typ_level")]
    public int? MsgTypLevel { get; set; }

    [Column("ext_procedure_bill_cd")]
    [StringLength(30)]
    public string? ExtProcedureBillCd { get; set; }

    [Column("ext_procedure_bill_cd_typ_id")]
    public int? ExtProcedureBillCdTypId { get; set; }

    [InverseProperty("BillCdNavigation")]
    public virtual ICollection<BillCdInstance> BillCdInstance { get; set; } = new List<BillCdInstance>();

    [ForeignKey("BillCdTypId")]
    [InverseProperty("BillCd")]
    public virtual BillCdTyp BillCdTyp { get; set; } = null!;

    [InverseProperty("BillCdNavigation")]
    public virtual ICollection<BillFormItem> BillFormItem { get; set; } = new List<BillFormItem>();

    [InverseProperty("BillCdNavigation")]
    public virtual ICollection<BillRelVal> BillRelVal { get; set; } = new List<BillRelVal>();

    [InverseProperty("BillCdNavigation")]
    public virtual InsPrecertBillCd? InsPrecertBillCd { get; set; }
}
