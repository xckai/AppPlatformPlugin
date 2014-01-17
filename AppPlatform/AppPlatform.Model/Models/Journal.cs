using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppPlatform.Model.Models
{
    
    public partial class Journal
    {
        [Key]
        [Required]
        [DisplayName("日志ID")]
        public int Journal_ID { get; set; }
        [Required]
        [DisplayName("日志名称")]
        public string Journal_Name { get; set; }
        [Required]
        [DisplayName("生成日志的用户")]
        public int User_ID { get; set; }
        [Required]
        [DisplayName("生成日志的时间")]
        public System.DateTime Journal_Time { get; set; }
        [Required]
        [DisplayName("日志等级")]
        public int Journal_Rank { get; set; }
        
        [DisplayName("备注")]
        public string Journal_Note { get; set; }
    }
}
