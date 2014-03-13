using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppPlatform.Model.Models
{
    public partial class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        [DisplayName("用户表主键")]
        public int User_ID { get; set; }
        [Required]
        [DisplayName("企业编号")]
        public int Enterprise_ID { get; set; }
        [Required]
        [DisplayName("密码")]
        public string Password { get; set; }
        
        [DisplayName("员工编号")]
        public int User_Code { get; set; }
        
        [DisplayName("用户姓名")]
        public string User_Name { get; set; }
        
        [DisplayName("身份证")]
        public string User_Card { get; set; }
        
        [DisplayName("用户照片")]
        public byte[] User_Photo { get; set; }
        [DisplayName("用户生日")]
        public Nullable<System.DateTime> User_Birthday { get; set; }
        
        [DisplayName("用户所属部门")]
        public string User_Depart { get; set; }
       
        [DisplayName("用户职位")]
        public string User_Position { get; set; }
        [DisplayName("职位描述")]
        public string User_Position_Des { get; set; }
        
        [DisplayName("用户性别")]
        public bool User_Sex { get; set; }
        
        [Phone]
        [DisplayName("用户手机号")]
        public string User_Tel { get; set; }
        [DisplayName("用户地址")]
        public string User_Addr { get; set; }
        
        [EmailAddress]
        [DisplayName("用户邮箱")]
        public string User_Email { get; set; }
        
        [DisplayName("用户状态")]
        public bool User_State { get; set; }
       
        [DisplayName("用户创建时间")]
        public Nullable<System.DateTime> User_Create_Time { get; set; }

        [DisplayName("用户备注")]
        public string User_Option { get; set; }

        public ICollection<User_Group> User_Groups { get; set; }//导航属性
        public ICollection<User_Role> User_Roles { get; set; }//导航属性
        public ICollection<User_InternalOrganization> User_InternalOrganizations { get; set; }//导航属性
        public ICollection<User_Internal_Authorization> User_Internal_Authorizations { get; set; }//导航属性
        public ICollection<User_Task> User_Tasks { get; set; }//导航属性
       
    }
}
