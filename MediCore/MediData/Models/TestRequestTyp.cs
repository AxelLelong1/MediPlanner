using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("test_request_typ")]
public partial class TestRequestTyp
{
    [Key]
    [Column("test_request_typ")]
    public int TestRequestTyp1 { get; set; }

    [Column("test_request_desc")]
    [StringLength(40)]
    public string TestRequestDesc { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [InverseProperty("TestRequestTypNavigation")]
    public virtual ICollection<Test> Test { get; set; } = new List<Test>();
}
