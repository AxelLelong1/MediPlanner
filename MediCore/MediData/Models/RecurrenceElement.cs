using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("RecurrenceRuleSer", Name = "XIF593RecurrencyElement")]
public partial class RecurrenceElement
{
    [Key]
    public long RecurrenceElementSer { get; set; }

    public long RecurrenceRuleSer { get; set; }

    public int ElementType { get; set; }

    public int ElementValue { get; set; }

    [ForeignKey("RecurrenceRuleSer")]
    [InverseProperty("RecurrenceElement")]
    public virtual RecurrenceRule RecurrenceRuleSerNavigation { get; set; } = null!;
}
