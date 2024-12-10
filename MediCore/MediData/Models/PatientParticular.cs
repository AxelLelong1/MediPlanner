using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class PatientParticular
{
    [Key]
    public long PatientSer { get; set; }

    [StringLength(32)]
    public string? UniversalPatientId { get; set; }

    [StringLength(32)]
    public string? PassportNumber { get; set; }

    [StringLength(64)]
    public string? PatientState { get; set; }

    [StringLength(16)]
    public string? MaritalStatus { get; set; }

    [StringLength(32)]
    public string? PregnancyStatus { get; set; }

    [StringLength(64)]
    public string? MedicalAlerts { get; set; }

    [StringLength(64)]
    public string? ContrastAllergies { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastMenstrualDate { get; set; }

    [StringLength(16)]
    public string? SmokingStatus { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RetireDate { get; set; }

    [StringLength(254)]
    public string? RetireReason { get; set; }

    [StringLength(254)]
    public string? RetireNote { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DeathDate { get; set; }

    [StringLength(254)]
    public string? DeathCause { get; set; }

    [StringLength(16)]
    public string? AutopsyStatus { get; set; }

    [StringLength(254)]
    public string? AutopsyOutcome { get; set; }

    [StringLength(16)]
    public string? BloodGroup { get; set; }

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

    [ForeignKey("PatientSer")]
    [InverseProperty("PatientParticular")]
    public virtual Patient PatientSerNavigation { get; set; } = null!;
}
