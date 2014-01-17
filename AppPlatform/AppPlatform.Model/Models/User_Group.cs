using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppPlatform.Model.Models
{
    public partial class User_Group
    {
        [Key]
        [Required]
        [DisplayName("用户分类ID")]
        public int User_Group_ID { get; set; }
        [Required]
        [DisplayName("分类ID")]
        public int Group_ID { get; set; }
        [Required]
        [DisplayName("用户ID")]
        public int User_ID { get; set; }

        public User User { get; set; }//导航属性
        public Group Group { get; set; }//导航属性
    }
}
