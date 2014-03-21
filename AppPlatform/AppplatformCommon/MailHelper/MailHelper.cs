using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.IO;

namespace AppplatformCommon.MailHelper
{
    public class MailHelper
    {
        /// <summary>
        /// 找回密码
        /// </summary>
        /// <param name="findUrl"></param>
        /// <param name="mailTo"></param>
        /// <returns></returns>
        
        /*
        public bool FindPwdMail(string findUrl, string mailTo)
        {
            //从配置中读取发送系统邮箱和密码
            string mailFrom = ConfigurationManager.AppSettings["sysMail"];
            string mailFromDisplayName = ConfigurationManager.AppSettings["sydMailDisplayName"];
            string mailPwd = ConfigurationManager.AppSettings["sysMailPwd"];
  
            using (MailMessage mail = new MailMessage())
            {
                //设置发件人地址；发件人姓名,默认为邮箱地址@前面的内容，姓名编码
                MailAddress mailF = new MailAddress(mailFrom, mailFromDisplayName, Encoding.UTF8);
                mail.From = mailF; //指定发件人
                //指定收件人
                mail.To.Add(mailTo);
                //邮件主题
                mail.Subject = "找回密码";
                mail.SubjectEncoding = Encoding.UTF8;
                //邮件内容
                mail.IsBodyHtml = true;
                mail.BodyEncoding = System.Text.Encoding.UTF8;
                StringBuilder body = new StringBuilder();
                body.Append("<div style=\"text-align:left;padding-left:20px;\">");
                //插入网站logo图片
                InsertImage(System.Web.HttpContext.Current.Server.MapPath("/images/bookCate.ico"), mail);
                body.Append("</div>");
                body.AppendFormat("<div style=\"padding:15px;clear: both; margin-right: auto; margin-left: auto;text-align: left;color: #039; line-height: 1.5em;\">亲爱的 {0}：", mailTo);
                body.Append("<div style=\"padding:15px 0 0 0\"><p>欢迎使用图书商城找回密码功能。请点击以下链接重置您的密码（链接12小时内有效） ：<br>");
                body.AppendFormat("<a href=\"{0}\" target=\"_blank\" title=\"点击重置您的密码\"><strong>{0}</strong></a></p>", findUrl);
                body.Append("<p style=\"padding-top:15px\">如果您没有申请找回密码，请忽略此邮件。</p>");
                body.AppendFormat("<p style=\"width:100%;text-align:left;padding-top:15px\">图书商城会员中心<br><span style=\"border-bottom:1px dashed #ccc;\" t=\"5\" times=\"\">{0}-{1}-{2}</span></p>", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                body.Append("<p style=\"color:#696969\">（本邮件由系统自动发出，请勿回复。）</p></div></div>");


                mail.Body += body.ToString();


                //邮件优先级
                mail.Priority = MailPriority.High;


                return SendMail(mailFrom, mailPwd, mail);
            }
        }
        */

        /// <summary>
        /// 激活邮箱
        /// </summary>
        /// <param name="activateUrl"></param>
        /// <param name="mailTo"></param>
        /// <returns></returns>
        public bool ActivateMail(string activateUrl, string mailTo)
        {
            //从配置中读取发送系统邮箱和密码
            /*
            string mailFrom = ConfigurationManager.AppSettings["sysMail"];
            string mailFromDisplayName = ConfigurationManager.AppSettings["sydMailDisplayName"];
            string mailPwd = ConfigurationManager.AppSettings["sysMailPwd"];
            */
            string mailFrom = "appplatform@126.com";
            string mailFromDisplayName = "AppPlatform";
            string mailPwd = "p@ssw0rd";
            using (MailMessage mail = new MailMessage())
            {
                //设置发件人地址；发件人姓名,默认为邮箱地址@前面的内容，姓名编码
                MailAddress mailF = new MailAddress(mailFrom, mailFromDisplayName, Encoding.UTF8);
                mail.From = mailF; //指定发件人
                //指定收件人
                mail.To.Add(mailTo);
                //邮件主题
                mail.Subject = "邮件激活";
                mail.SubjectEncoding = Encoding.UTF8;
                //邮件内容
                mail.IsBodyHtml = true;
                mail.BodyEncoding = System.Text.Encoding.UTF8;
                StringBuilder body = new StringBuilder();
                body.Append("<div style=\"width:680px;padding:0 10px;margin:0 auto;\"><div style=\"line-height:1.5;font-size:14px;margin-bottom:25px;color:#4d4d4d;\"><strong style=\"display:block;margin-bottom:15px;\">亲爱的会员：您好！</strong>");
                body.AppendFormat("<p>恭喜您成为企业云平台的一员，你注册的Email账户{0}，点击下面的链接激活。</p></div>", mailTo);
                body.AppendFormat("<div style=\"margin-bottom:30px;\"><strong style=\"display:block;margin-bottom:20px;font-size:14px;\"><a target=\"_blank\" style=\"color:#f60;\" href=\"{0}\">点此立即激活</a></strong>", activateUrl);
                body.Append("<p style=\"color:#666;\"><small style=\"display:block;font-size:12px;margin-bottom:5px;\">如果上述文字点击无效，请把下面网页地址复制到浏览器地址栏中打开：</small>");
                body.AppendFormat("<span style=\"color:#666;\"><a href=\"{0}\" target=\"_blank\">{0}</a></span></p></div></div>", activateUrl);
                mail.Body += body.ToString();


                //邮件优先级
                mail.Priority = MailPriority.High;

                return SendMail(mailFrom, mailPwd, mail);
            }
        }


        private bool SendMail(string mailFrom, string mailPwd, MailMessage mail)
        {
            using (SmtpClient Client = GetSmtpClient(mailFrom, mailPwd))
            {
                try
                {
                    Client.Send(mail);
                }
                catch (SmtpFailedRecipientsException ex)
                {
                    for (int i = 0; i < ex.InnerExceptions.Length; i++)
                    {
                        SmtpStatusCode status = ex.InnerExceptions[i].StatusCode;
                        if (status == SmtpStatusCode.MailboxBusy || status == SmtpStatusCode.MailboxUnavailable)
                        {
                            //Response.Write("Delivery failed - retrying in 5 seconds.");
                            System.Threading.Thread.Sleep(5000);
                            Client.Send(mail);
                        }
                    }
                }
                catch
                {
                    return false;
                }
                finally
                {   //如果有附加，则释放附件占用excel资源
                    for (int i = 0; i < mail.Attachments.Count; i++)
                    {
                        mail.Attachments[i].Dispose();
                    }
                }
                return true;
            }
        }


        /// <summary>
        ///  设置邮件协议，需传人发送邮箱地址和密码
        /// </summary>
        /// <param name="mailFrom">邮箱地址</param>
        /// <param name="mailPwd">密码</param>
        /// <returns></returns>
        private SmtpClient GetSmtpClient(string mailFrom, string mailPwd)
        {
            string[] sendUsername = mailFrom.Split('@');
            SmtpClient client = new SmtpClient("smtp." + sendUsername[1].ToString());


            client.UseDefaultCredentials = false;//这一句得写前面
            //client.EnableSsl = true;//服务器不支持SSL连接


            client.DeliveryMethod = SmtpDeliveryMethod.Network; //通过网络发送到Smtp服务器
            //通过用户名和密码 认证
            client.Credentials = new System.Net.NetworkCredential(sendUsername[0].ToString(), mailPwd);
            return client;
        }


        /// <summary>
        /// 在邮件内容中添加图片
        /// </summary>
        /// <param name="filePath">图片在服务器上面的绝对路径</param>
        /// <param name="mail"></param>
        private void InsertImage(string filePath, MailMessage mail)
        {
            if (!File.Exists(filePath))
            {
                return;
            }
            System.Net.Mail.Attachment attachment = new System.Net.Mail.Attachment(filePath);
            mail.Attachments.Add(attachment);
            mail.Body += "<img src=\"cid:" + attachment.ContentId + "\"/>";
        }


        /// <summary>
        /// 添加邮件附件
        /// </summary>
        /// <param name="filePath">文件在服务器上面的绝对路径</param>
        /// <param name="mail"></param>
        private void AddAttachment(string filePath, MailMessage mail)
        {
            if (!File.Exists(filePath))
            {
                return;
            }
            Attachment data = new Attachment(filePath, System.Net.Mime.MediaTypeNames.Application.Octet);
            //使用这些代码，会有这个异常：在邮件标头中找到无效的字符:“周”
            //参考：http://www.cnblogs.com/wybin/archive/2012/08/30/2663679.html
            //System.Net.Mime.ContentDisposition disposition = data.ContentDisposition;
            //disposition.CreationDate = File.GetCreationTime(filePath);
            //disposition.ModificationDate = File.GetLastWriteTime(filePath);
            //disposition.ReadDate = File.GetLastAccessTime(filePath);
            mail.Attachments.Add(data);
        }
    }
}
