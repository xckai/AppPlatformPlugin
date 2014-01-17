using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppPlatform.Model.Models
{
    
    public partial class User_Internal_Authorization
    {
        [Key]
        [Required]
       
        public int User_Internal_Authorization_ID { get; set; }//主键
        public int Internal_Authorization_ID { get; set; }//外键
        public int User_ID { get; set; }//外键

        //导航属性
        public User user { get; set; }
        public Internal_Authorization Internal_Authorization { get; set; }
    }

}
