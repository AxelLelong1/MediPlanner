using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stg_test_request_typ", Schema = "DWH")]
public partial class StgTestRequestTyp
{
    [Column("table_name")]
    [StringLength(60)]
    public string? TableName { get; set; }

    [Column("test_request_typ")]
    public int? TestRequestTyp { get; set; }
}
