using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppPlatform.Model.Models
{
    public partial class EnterpriseClass
    {

        [Key]
        [Required]
        [DisplayName("分类编号")]
        public int EnterpriseClass_ID { get; set; }//主键
        [Required]
        [DisplayName("分类名称")]
        public string EnterpriseClass_Name { get; set; }

        [DisplayName("备注")]
        public string EnterpriseClass_Option { get; set; }


        public ICollection<Enterprise_EnterpriseClass> Enterprise_EnterpriseClasses { get; set; }//导航属性
    }
}
