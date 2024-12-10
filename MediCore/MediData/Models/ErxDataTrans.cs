using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("erx_data_trans")]
[Index("ErxSeg", "ErxTag", Name = "nc1_erx_data_trans")]
public partial class ErxDataTrans
{
    [Key]
    [Column("erx_data_id")]
    public int ErxDataId { get; set; }

    [Column("erx_seg")]
    [StringLength(25)]
    public string ErxSeg { get; set; } = null!;

    [Column("erx_tag")]
    [StringLength(50)]
    public string ErxTag { get; set; } = null!;

    [Column("erx_sub_tag")]
    [StringLength(50)]
    public string? ErxSubTag { get; set; }

    [Column("db_table")]
    [StringLength(25)]
    public string? DbTable { get; set; }

    [Column("db_field")]
    [StringLength(25)]
    public string? DbField { get; set; }

    [Column("seq_no")]
    public int? SeqNo { get; set; }

    [Column("new_rec_ind")]
    [StringLength(1)]
    public string? NewRecInd { get; set; }

    [Column("sub_tab_ind")]
    [StringLength(1)]
    public string? SubTabInd { get; set; }
}
