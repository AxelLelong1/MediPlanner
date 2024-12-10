using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("TransportationSer", Name = "XIF996PatientTrnsprtn")]
[Index("PatientSer", Name = "XIF997PatientTrnsprtn")]
public partial class PatientTransportation
{
    [Key]
    public long PatientTransportationSer { get; set; }

    public long PatientSer { get; set; }

    public long? TransportationSer { get; set; }

    [StringLength(64)]
    public string? TransportationName { get; set; }

    [StringLength(64)]
    public string? TransportationPhone { get; set; }

    [StringLength(254)]
    public string? TransportationComment { get; set; }

    public int PrimaryFlag { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("PatientSer")]
    [InverseProperty("PatientTransportation")]
    public virtual Patient PatientSerNavigation { get; set; } = null!;

    [ForeignKey("TransportationSer")]
    [InverseProperty("PatientTransportation")]
    public virtual Transportation? TransportationSerNavigation { get; set; }
}
