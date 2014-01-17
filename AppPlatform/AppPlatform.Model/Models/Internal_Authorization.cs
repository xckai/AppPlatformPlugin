using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppPlatform.Model.Models
{
    public partial class Internal_Authorization
    {
        [Key]
        [Required]
        [DisplayName("App内部权限ID")]
        public int Internal_Authorization_ID { get; set; }//主键

        [Required]
        [DisplayName("应用编号")]
        public int App_ID { get; set; }//外键

        [Required]
        [DisplayName("权限名称")]
        public string Internal_Authorization_Name { get; set; }

        [Required]
        [DisplayName("权限描述")]
        public string nternal_Authorization_Desc { get; set; }

 
        [DisplayName("备注")]
        public string Internal_Authorization_Note { get; set; }

        public App App { get; set; }//导航属性
        public ICollection<User_Internal_Authorization> User_Internal_Authorizations { get; set; }//导航属性
    }
}
