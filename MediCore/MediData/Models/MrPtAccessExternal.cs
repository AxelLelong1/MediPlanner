using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("Userid", "UserInstId", "InstId", "PtKeyValue")]
[Table("mr_pt_access_external")]
public partial class MrPtAccessExternal
{
    [Key]
    [Column("userid")]
    [StringLength(255)]
    public string Userid { get; set; } = null!;

    [Key]
    [Column("user_inst_id")]
    [StringLength(30)]
    public string UserInstId { get; set; } = null!;

    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("pt_key_value")]
    [StringLength(25)]
    public string PtKeyValue { get; set; } = null!;

    [Column("pt_last_name")]
    [StringLength(30)]
    public string? PtLastName { get; set; }

    [Column("pt_access_tstamp", TypeName = "datetime")]
    public DateTime? PtAccessTstamp { get; set; }
}
