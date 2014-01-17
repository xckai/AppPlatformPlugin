using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppPlatform.Model.Models
{
    public partial class Group
    {
        [Key]
        [Required]
        [DisplayName("分类ID")]
        public int Group_ID { get; set; }//主键
        [Required]
        [DisplayName("分类名称")]
        public string Group_Name { get; set; }
        [DisplayName("分类描述")]
        public string Group_Desc { get; set; }
        [DisplayName("备注")]
        public string Group_Note { get; set; }

        public ICollection<User_Group> User_Groups { get; set; }//导航属性

        public ICollection<Group_Function> Group_Function { get; set; }
    }
}
