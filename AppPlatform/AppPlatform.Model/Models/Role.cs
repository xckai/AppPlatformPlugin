using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppPlatform.Model.Models
{
    public partial class Role
    {
        [Key]
        [Required]
        [DisplayName("角色编号")]
        public int Role_ID { get; set; }
        [Required]
        [DisplayName("企业编号")]
        public int Enterprise_ID { get; set; }
        [Required]
        [DisplayName("角色名称")]
        public string Role_Name { get; set; }
        [DisplayName("角色描述")]
        public string Role_Description { get; set; }
        [DisplayName("角色备注")]
        public string Role_Option { get; set; }

        public Enterprise Enterprise { get; set; }//导航属性
        public ICollection<User_Role> User_Roles { get; set; }//导航属性
        public ICollection<App_Role> App_Roles { get; set; }//导航属性
    }
}
