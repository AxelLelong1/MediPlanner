using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimInstituteLocation
{
    [Column("inst_id")]
    [StringLength(30)]
    public string? InstId { get; set; }

    [Column("ctrloc_id")]
    public int CtrlocId { get; set; }

    [Column("ctrbldg_id")]
    public int CtrbldgId { get; set; }

    [Column("ctrfloor_id")]
    public int CtrfloorId { get; set; }

    [Column("ctrroom_id")]
    public int CtrroomId { get; set; }

    [StringLength(40)]
    public string LocationDescription { get; set; } = null!;

    public int? Capacity { get; set; }

    [StringLength(40)]
    public string EventType { get; set; } = null!;

    [StringLength(1)]
    public string? PrimaryInd { get; set; }

    [StringLength(1)]
    public string? ActiveEntryInd { get; set; }

    public int? SlotSize { get; set; }

    [StringLength(30)]
    public string? DepartmentName { get; set; }

    [StringLength(1)]
    public string? OutbndSchInd { get; set; }

    [StringLength(4)]
    public string? LocationOpenTime { get; set; }

    [StringLength(4)]
    public string? LocationCloseTime { get; set; }

    [StringLength(255)]
    public string? LocationComment { get; set; }

    [StringLength(28)]
    public string? LocationTel { get; set; }

    [StringLength(200)]
    public string? LocationUnavlComment { get; set; }

    [StringLength(30)]
    public string? BuildingName { get; set; }

    [StringLength(30)]
    public string? FloorName { get; set; }

    [StringLength(30)]
    public string? RoomName { get; set; }

    [StringLength(30)]
    public string? LocationGroupName { get; set; }
}
