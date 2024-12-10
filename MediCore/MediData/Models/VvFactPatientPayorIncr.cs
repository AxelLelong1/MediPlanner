using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvFactPatientPayorIncr
{
    [Column("ctrPatientSer")]
    public long CtrPatientSer { get; set; }

    [Column("ctrPayorSer")]
    public long CtrPayorSer { get; set; }

    public int IsPrimaryPayor { get; set; }

    public int IsSecondaryPayor { get; set; }

    [StringLength(64)]
    public string? PayorInsuredName { get; set; }

    [StringLength(16)]
    public string? PayorAuthorizationId { get; set; }

    [StringLength(254)]
    public string? PayorComment { get; set; }

    [StringLength(16)]
    public string? PayorPolicyNumber { get; set; }

    [StringLength(64)]
    public string? PayorRelationshipwithInsured { get; set; }

    [StringLength(20)]
    public string? PayorCurrentAccountNumber { get; set; }

    public double? PrcntOfPaymnt { get; set; }

    [Column(TypeName = "money")]
    public decimal? CoPayment { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? VerificationDate { get; set; }

    [Column("ctrPatientPayorSer")]
    public long CtrPatientPayorSer { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PayorAuthorizationDate { get; set; }
}
