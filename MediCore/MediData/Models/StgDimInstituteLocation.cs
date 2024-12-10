using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimInstituteLocation", Schema = "DWH")]
public partial class StgDimInstituteLocation
{
    [Column("inst_id")]
    [StringLength(30)]
    public string? InstId { get; set; }

    [Column("loc_id")]
    public int? LocId { get; set; }

    [Column("bldg_id")]
    public int? BldgId { get; set; }

    [Column("floor_id")]
    public int? FloorId { get; set; }

    [Column("room_id")]
    public int? RoomId { get; set; }
}
