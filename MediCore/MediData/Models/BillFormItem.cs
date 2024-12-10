using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("bill_form_item")]
public partial class BillFormItem
{
    [Key]
    [Column("bill_item_id")]
    public int BillItemId { get; set; }

    [Column("bill_cd")]
    [StringLength(30)]
    public string BillCd { get; set; } = null!;

    [Column("bill_cd_typ_id")]
    public int BillCdTypId { get; set; }

    [Column("bill_form_id")]
    public int BillFormId { get; set; }

    [Column("bill_event_typ_id")]
    public int BillEventTypId { get; set; }

    [Column("bill_item_desc")]
    [StringLength(255)]
    public string? BillItemDesc { get; set; }

    [Column("bill_group_name")]
    [StringLength(30)]
    public string BillGroupName { get; set; } = null!;

    [Column("group_disp_order")]
    public int GroupDispOrder { get; set; }

    [Column("item_order_in_group")]
    public int ItemOrderInGroup { get; set; }

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

    [Column("bill_modifier")]
    [StringLength(20)]
    public string? BillModifier { get; set; }

    [ForeignKey("BillCd, BillCdTypId")]
    [InverseProperty("BillFormItem")]
    public virtual BillCd BillCdNavigation { get; set; } = null!;

    [ForeignKey("BillEventTypId")]
    [InverseProperty("BillFormItem")]
    public virtual BillEventTyp BillEventTyp { get; set; } = null!;

    [ForeignKey("BillFormId")]
    [InverseProperty("BillFormItem")]
    public virtual BillForm BillForm { get; set; } = null!;
}
