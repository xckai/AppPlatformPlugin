using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppPlatform.Model.Models
{
    public partial class App_Role
    {
        [Key]
        [Required]
        public int App_Role_ID { get; set; }//主键

        [Required]
        [DisplayName("角色ID")]
        public int Role_ID { get; set; }//外键

        [Required]
        [DisplayName("AppID")]
        public int App_ID { get; set; }//外键

        [DisplayName("使用权限")]
        public Nullable<bool> Use_right { get; set; }

        [DisplayName("管理权限")]
        public Nullable<bool> Manage_right { get; set; }

        public Role Role { get; set; }//导航属性
        public App App { get; set; }//导航属性
    }

}
