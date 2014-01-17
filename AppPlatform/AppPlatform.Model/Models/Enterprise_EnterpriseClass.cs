using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppPlatform.Model.Models
{
    public partial class Enterprise_EnterpriseClass
    {


        [Key]
        [Required]
        public int Enterprise_EnterpriseClass_ID { get; set; }//主键

        [Required]
        [DisplayName("企业编号")]
        public int Enterprise_ID { get; set; }//外键

        [Required]
        [DisplayName("分类编号")]
        public int EnterpriseClass_ID { get; set; }//外键


        public Enterprise Enterprise { get; set; }//导航属性
        public EnterpriseClass EnterpriseClass { get; set; }//导航属性

    }
}
