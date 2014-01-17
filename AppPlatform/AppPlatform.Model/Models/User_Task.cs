using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppPlatform.Model.Models
{
    public partial class User_Task
    {
        [Key]
        [Required]
        [DisplayName("用户任务ID")]
        public int User_Task_ID { get; set; }//主键

        [Required]
        [DisplayName("任务ID")]

        public int Task_ID { get; set; }//外键
        [Required]
        [DisplayName("用户ID")]
        public int User_ID { get; set; }//外键


        //导航属性
        public User user { get; set; }
        public TaskList Task { get; set; }
    }
}
