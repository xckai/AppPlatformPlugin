using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppPlatform.Model.Models
{
    public partial class User_Role
    {
        [Key]
        [Required]
        [DisplayName("")]
        public int User_Role_ID { get; set; }
        [Required]
        [DisplayName("角色编号")]
        public int RoleList_ID { get; set; }
        [Required]
        [DisplayName("用户编号")]
        public int User_ID { get; set; }

        public User User { get; set; }//导航属性
        public Role Role { get; set; }//导航属性
    }
}
