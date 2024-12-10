using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class SecndryDiagnosis
{
    public long? DiagnosisSer { get; set; }

    public int? MetastasisFlag { get; set; }
}
