using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvFactPatientPrescription
{
    [Column("ctrPrescriptionSer")]
    public long CtrPrescriptionSer { get; set; }

    [Column("ctrPrescriptionPropertySer")]
    public long? CtrPrescriptionPropertySer { get; set; }

    [Column("ctrPrescriptionPropertyItemSer")]
    public long CtrPrescriptionPropertyItemSer { get; set; }

    [Column("ctrPrescriptionAnatomySer")]
    public long? CtrPrescriptionAnatomySer { get; set; }

    [Column("ctrPrescriptionAnatomyItemSer")]
    public long CtrPrescriptionAnatomyItemSer { get; set; }

    [Column("ctrPatientSer")]
    public long? CtrPatientSer { get; set; }

    [Column("ctrCourseSer")]
    public long? CtrCourseSer { get; set; }

    public long DiagnosisSer { get; set; }
}
