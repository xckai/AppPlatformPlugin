using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace AppPlatform.Model.Models
{
    
    public partial class Group_Function
    {
        [Key]
        [Required]
        [DisplayName("主键")]
        public int Group_Function_ID { get; set; }

        [Required]
        [DisplayName("功能ID")]
        public int Function_ID { get; set; }

        [Required]
        [DisplayName("用户组ID")]
        public int Group_ID { get; set; }

        //导航属性
        public Group Group { get; set; }
        public Function Function { get; set; }
    }
}
