using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("HospitalSer", Name = "XIF998Trnsprtn")]
public partial class Transportation
{
    [Key]
    public long TransportationSer { get; set; }

    public long HospitalSer { get; set; }

    [StringLength(64)]
    public string TransportationName { get; set; } = null!;

    [StringLength(64)]
    public string TransportationPhone { get; set; } = null!;

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("HospitalSer")]
    [InverseProperty("Transportation")]
    public virtual Hospital HospitalSerNavigation { get; set; } = null!;

    [InverseProperty("TransportationSerNavigation")]
    public virtual ICollection<PatientTransportation> PatientTransportation { get; set; } = new List<PatientTransportation>();
}
