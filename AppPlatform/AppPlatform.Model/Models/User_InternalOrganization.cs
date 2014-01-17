using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace AppPlatform.Model.Models
{
    public partial class User_InternalOrganization
    {
        [Key]
        [Required]
        [DisplayName("用户部门编号")]
        public int User_InternalOrganization_ID { get; set; }
        [Required]
        [DisplayName("用户编号")]
        public int User_ID { get; set; }
        [Required]
        [DisplayName("部门编号")]
        public int InternalOrganization_ID { get; set; }

        public User User { get; set; }//导航属性
        public InternalOrganization InternalOrganization { get; set; }//导航属性
    }
}
