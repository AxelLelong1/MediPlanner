using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("Message")]
[Index("ResourceSer", Name = "XIF680Message")]
public partial class Message1
{
    [Key]
    public long MessageSer { get; set; }

    public long ResourceSer { get; set; }

    public string? MessageText { get; set; }

    public int DeletedFlag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreationDate { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("MessageSerNavigation")]
    public virtual ICollection<Recipient> Recipient { get; set; } = new List<Recipient>();

    [ForeignKey("ResourceSer")]
    [InverseProperty("Message1")]
    public virtual Resource ResourceSerNavigation { get; set; } = null!;
}
