using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("educ_topics")]
public partial class EducTopics
{
    [Key]
    [Column("educ_topic_id")]
    public int EducTopicId { get; set; }

    [Column("educ_topic")]
    [StringLength(60)]
    public string? EducTopic { get; set; }

    [Column("educ_topic_desc")]
    [StringLength(60)]
    public string? EducTopicDesc { get; set; }

    [Column("educ_topic_typ")]
    public int? EducTopicTyp { get; set; }

    [Column("educ_cat_id")]
    public int? EducCatId { get; set; }

    [Column("topic_query")]
    public string? TopicQuery { get; set; }

    [Column("num_content")]
    public int? NumContent { get; set; }

    [Column("active_entry_ind")]
    [StringLength(1)]
    public string? ActiveEntryInd { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
