using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppPlatform.Model.Models
{
    public partial class App_AppClass
    {

        [Key]
        [Required]
        [DisplayName("应用分类编号")]
        public int App_AppClass_ID { get; set; }//主键

        [Required]
        [DisplayName("应用编号")]
        public int App_ID { get; set; } //外键

        [Required]
        [DisplayName("分类编号")]
        public int AppClass_ID { get; set; }//外键

        public App App { get; set; }//导航属性
        public AppClass AppClass { get; set; }//导航属性
    }
}
