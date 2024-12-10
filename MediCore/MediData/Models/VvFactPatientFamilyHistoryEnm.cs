using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvFactPatientFamilyHistoryEnm
{
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Column("FamilyMemberDOBID")]
    [StringLength(10)]
    [Unicode(false)]
    public string FamilyMemberDobid { get; set; } = null!;

    [StringLength(1)]
    public string? AliveIndicator { get; set; }

    public int? AgeAtDeath { get; set; }

    public int FamilyRelationType { get; set; }

    [Column("FamilyMemberDOB", TypeName = "datetime")]
    public DateTime? FamilyMemberDob { get; set; }

    [StringLength(1)]
    public string CancerIndicator { get; set; } = null!;

    [StringLength(1)]
    public string? ValidEntryIndicator { get; set; }

    [Column("ctrFamilyHistoryId")]
    public int CtrFamilyHistoryId { get; set; }

    [Column("ctrPatientSer")]
    public long? CtrPatientSer { get; set; }
}
