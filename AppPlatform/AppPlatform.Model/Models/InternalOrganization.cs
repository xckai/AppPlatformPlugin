using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppPlatform.Model.Models
{
    public partial class InternalOrganization
    {
        [Key]
        [Required]
        [DisplayName("部门编号")]
        public int InternalOrganization_ID { get; set; }
        [Required]
        [DisplayName("企业编号")]
        public int Enterprise_ID { get; set; }
        [Required]
        [DisplayName("部门名称")]
        public string InternalOrganization_Name { get; set; }
        [DisplayName("描述")]
        public string InternalOrganization_Desc { get; set; }
        [DisplayName("上级部门")]
        public Nullable<int> InternalOrganization_PID { get; set; }
        [DisplayName("备注")]
        public string InternalOrganization_Note { get; set; }

        public Enterprise Enterprise { get; set; }//导航属性
        public ICollection<User_InternalOrganization> User_InternalOrganiaztions { get; set; }//导航属性
    }
}
