using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace AppPlatform.Model.Models
{
    
    public class App
  
   {
        [Key]
        [Required]
        [DisplayName("应用编号")]
        public int App_ID { get; set; }//主键

        
        [Required]
        [DisplayName("应用名称")]
        public string App_Name { get; set; }

        
        [Required]
        [DisplayName("应用Logo")]
        public byte[] App_Logo { get; set; }

        [Required]
        [DisplayName("应用描述")]
        public string App_Description { get; set; }

        [Url]
        [Required]
        [DisplayName("应用地址")]
        public string App_url { get; set; }

        [Required]
        [DisplayName("浏览次数")]
        public long App_BrowseNum { get; set; }

        [Required]
        [DisplayName("下载次数")]
        public long App_DownNum { get; set; }

        [Required]
        [DisplayName("应用界面")]
        public byte[] App_Gragh { get; set; }

        [Required]
        [DisplayName("上传时间")]
        
        public System.DateTime AppUpdate_Time { get; set; }

        [Required]
        [DisplayName("状态")]
        public bool App_State { get; set; }

        [DisplayName("备注")]
        public string App_Option { get; set; }

        public ICollection<App_AppClass> App_AppClasses { get; set; }//导航属性
        public ICollection<App_Role> App_Roles { get; set; } //导航属性
        public ICollection<Internal_Authorization> Internal_Authorizations { get; set; } //导航属性
        public ICollection<Enterprise_App> Enterprise_Apps { get; set; } //导航属性

       
    }
}
