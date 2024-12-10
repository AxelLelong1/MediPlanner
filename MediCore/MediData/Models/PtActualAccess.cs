using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtVisitId", "PtActualId", "EventTyp")]
[Table("pt_actual_access")]
public partial class PtActualAccess
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Key]
    [Column("pt_actual_id")]
    public int PtActualId { get; set; }

    [Key]
    [Column("event_typ")]
    [StringLength(1)]
    public string EventTyp { get; set; } = null!;

    [Column("userid")]
    [StringLength(255)]
    public string Userid { get; set; } = null!;

    [Column("user_inst_id")]
    [StringLength(30)]
    public string UserInstId { get; set; } = null!;

    [Column("access_tstamp", TypeName = "datetime")]
    public DateTime AccessTstamp { get; set; }
}
