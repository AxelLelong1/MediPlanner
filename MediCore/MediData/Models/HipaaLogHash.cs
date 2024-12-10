using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("hipaa_log_hash")]
public partial class HipaaLogHash
{
    [Key]
    [Column("log_file_date", TypeName = "datetime")]
    public DateTime LogFileDate { get; set; }

    [Column("hash_value")]
    [MaxLength(32)]
    public byte[] HashValue { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }
}
