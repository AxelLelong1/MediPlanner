using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class PatientBenefitCache
{
    [Key]
    public long PatientBenefitCacheId { get; set; }

    [StringLength(20)]
    public string PatientId { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ExpiryDate { get; set; }

    [StringLength(150)]
    public string PayorName { get; set; } = null!;

    [StringLength(255)]
    public string? PayorDetails { get; set; }

    [StringLength(80)]
    public string PayorId { get; set; } = null!;

    [StringLength(80)]
    public string? PbmMemberId { get; set; }

    [StringLength(50)]
    public string? FormularyId { get; set; }

    [StringLength(50)]
    public string? AlternativeId { get; set; }

    [StringLength(50)]
    public string? CoverageListId { get; set; }

    [StringLength(50)]
    public string? CopayId { get; set; }

    [StringLength(1000)]
    public string? WarningText { get; set; }

    [StringLength(15)]
    public string? MessageId { get; set; }

    [StringLength(35)]
    public string? CardHolderId { get; set; }

    [StringLength(35)]
    public string? CardHolderLastName { get; set; }

    [StringLength(35)]
    public string? CardHolderFirstName { get; set; }

    [StringLength(35)]
    public string? CardHolderMiddleName { get; set; }

    [StringLength(35)]
    public string? CardHolderSuffix { get; set; }

    [StringLength(35)]
    public string? GroupId { get; set; }

    [StringLength(9)]
    public string? SocialSecurityNumber { get; set; }

    [StringLength(6)]
    public string? BankIdentificationNumber { get; set; }

    [StringLength(80)]
    public string? ProcessControlNumber { get; set; }
}
