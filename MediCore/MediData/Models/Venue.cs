using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("VenueId", Name = "XAK1Venue", IsUnique = true)]
public partial class Venue
{
    [Key]
    public long ResourceSer { get; set; }

    [StringLength(16)]
    public string VenueId { get; set; } = null!;

    [StringLength(64)]
    public string? VenueType { get; set; }

    [StringLength(64)]
    public string? VenueName { get; set; }

    public string? VenueDirections { get; set; }

    [StringLength(16)]
    public string? RoomNumber { get; set; }

    public int? ScheduleFlag { get; set; }

    public string? EquipmentList { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [InverseProperty("ResourceSerNavigation")]
    public virtual ICollection<PatientLocation> PatientLocation { get; set; } = new List<PatientLocation>();

    [ForeignKey("ResourceSer")]
    [InverseProperty("Venue")]
    public virtual Resource ResourceSerNavigation { get; set; } = null!;

    [InverseProperty("VenueResourceSerNavigation")]
    public virtual ICollection<ResourceVenue> ResourceVenue { get; set; } = new List<ResourceVenue>();
}
