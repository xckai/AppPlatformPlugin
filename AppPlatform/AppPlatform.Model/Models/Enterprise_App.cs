using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppPlatform.Model.Models
{
    public partial class Enterprise_App
    {
        [Key]
        [Required]
        public int Enterprise_App_ID { get; set; }//主键

        [Required]
        [DisplayName("应用编号")]
        public int App_ID { get; set; }//外键

        [Required]
        [DisplayName("企业编号")]
        public int Enterprise_ID { get; set; }//外键

        [Required]
        [DisplayName("企业角色")]
        public string Enterprise_App_Role { get; set; }


        public App App { get; set; } //导航属性
        public Enterprise Enterprise { get; set; }//导航属性
    }
}
