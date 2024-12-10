using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("tlbr_item")]
public partial class TlbrItem
{
    [Key]
    [Column("item_id")]
    public int ItemId { get; set; }

    [Column("item_name")]
    [StringLength(30)]
    public string ItemName { get; set; } = null!;

    [Column("item_abrv")]
    [StringLength(30)]
    public string ItemAbrv { get; set; } = null!;

    [Column("parent_menu_id")]
    public int ParentMenuId { get; set; }

    [Column("menu_id")]
    public int MenuId { get; set; }

    [Column("dflt_icon")]
    [StringLength(30)]
    public string? DfltIcon { get; set; }

    [Column("dflt_tlbr_sort_order")]
    public int? DfltTlbrSortOrder { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [InverseProperty("Item")]
    public virtual ICollection<TlbrUserItem> TlbrUserItem { get; set; } = new List<TlbrUserItem>();
}
