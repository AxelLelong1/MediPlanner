using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimPatientUserDefinedLabels
{
    [StringLength(16)]
    public string? UserDefAttrib01 { get; set; }

    [StringLength(16)]
    public string? UserDefAttrib02 { get; set; }

    [StringLength(16)]
    public string? UserDefAttrib03 { get; set; }

    [StringLength(16)]
    public string? UserDefAttrib04 { get; set; }

    [StringLength(16)]
    public string? UserDefAttrib05 { get; set; }

    [StringLength(16)]
    public string? UserDefAttrib06 { get; set; }

    [StringLength(16)]
    public string? UserDefAttrib07 { get; set; }

    [StringLength(16)]
    public string? UserDefAttrib08 { get; set; }

    [StringLength(16)]
    public string? UserDefAttrib09 { get; set; }

    [StringLength(16)]
    public string? UserDefAttrib10 { get; set; }

    [StringLength(16)]
    public string? UserDefAttrib11 { get; set; }

    [StringLength(16)]
    public string? UserDefAttrib12 { get; set; }

    [StringLength(16)]
    public string? UserDefAttrib13 { get; set; }

    [StringLength(16)]
    public string? UserDefAttrib14 { get; set; }

    [StringLength(16)]
    public string? UserDefAttrib15 { get; set; }

    [StringLength(16)]
    public string? UserDefAttrib16 { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string LookupUserDefAttrib01 { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string LookupUserDefAttrib02 { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string LookupUserDefAttrib03 { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string LookupUserDefAttrib04 { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string LookupUserDefAttrib05 { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string LookupUserDefAttrib06 { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string LookupUserDefAttrib07 { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string LookupUserDefAttrib08 { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string LookupUserDefAttrib09 { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string LookupUserDefAttrib10 { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string LookupUserDefAttrib11 { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string LookupUserDefAttrib12 { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string LookupUserDefAttrib13 { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string LookupUserDefAttrib14 { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string LookupUserDefAttrib15 { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string LookupUserDefAttrib16 { get; set; } = null!;

    [Column("ctrPatientSer")]
    public long CtrPatientSer { get; set; }
}
