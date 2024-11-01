using System.Net;
using System.Net.Http.Headers;
using System.Net.Mail;

namespace HW_smtp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            List<string> recipients = new List<string>();

            MailAddress from = new MailAddress("ex@mail.com", "Tom");
            MailMessage mess = new MailMessage()
            {
                Subject = "Text",
                Body = "Mail test",
                IsBodyHtml = true,
                From = from
            };

            foreach (string recipient in recipients)
            {
                mess.To.Add(recipient);
            }
             
            SmtpClient smtp = new SmtpClient("smtp.gmail.com",587);
            smtp.Credentials = new NetworkCredential("somemail@gmail.com", "Application password");
            smtp.EnableSsl = true;
            smtp.Send(mess);
        }
    }
}
