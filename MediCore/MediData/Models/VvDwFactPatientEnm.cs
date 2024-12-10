using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDwFactPatientEnm
{
    [StringLength(64)]
    public string? PatientCitizenShip { get; set; }

    [StringLength(64)]
    public string? PatientRace { get; set; }

    [StringLength(16)]
    public string? PatientSex { get; set; }

    [StringLength(32)]
    public string? PatientStatus { get; set; }

    [StringLength(64)]
    public string? PatientCity { get; set; }

    [StringLength(64)]
    public string? PatientCountry { get; set; }

    [StringLength(64)]
    public string? PatientCounty { get; set; }

    [StringLength(16)]
    public string? PostalCode { get; set; }

    [StringLength(64)]
    public string? State { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PatientCreationDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PatientAdmissionDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PatientDischargeDate { get; set; }

    [Column("ctrPatientSer")]
    public long CtrPatientSer { get; set; }

    [Column("ctrHospitalSer")]
    public long? CtrHospitalSer { get; set; }

    [Column("ctrDepartmentSer")]
    public long? CtrDepartmentSer { get; set; }

    [Column("ctrPrimaryOncologistSer")]
    public long? CtrPrimaryOncologistSer { get; set; }

    [Column("ctrPrimaryReferringPhysicianSer")]
    public long? CtrPrimaryReferringPhysicianSer { get; set; }

    [Column("ctrprovider_stkh_id_PrimaryOncologist")]
    [StringLength(20)]
    public string? CtrproviderStkhIdPrimaryOncologist { get; set; }

    [Column("ctrprovider_stkh_id_RefPhysician")]
    [StringLength(20)]
    public string? CtrproviderStkhIdRefPhysician { get; set; }

    [Column("ctrinst_id")]
    [StringLength(30)]
    public string? CtrinstId { get; set; }
}
