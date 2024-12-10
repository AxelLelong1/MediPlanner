using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("bsa_formula_typ")]
public partial class BsaFormulaTyp
{
    [Key]
    [Column("bsa_formula_typ")]
    public int BsaFormulaTyp1 { get; set; }

    [Column("bsa_formula_name")]
    [StringLength(20)]
    public string BsaFormulaName { get; set; } = null!;

    [Column("bsa_formula_desc")]
    [StringLength(50)]
    public string BsaFormulaDesc { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
