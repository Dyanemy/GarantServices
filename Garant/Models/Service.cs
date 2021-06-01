using Microsoft.Extensions.Logging;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garant.Models
{
    public class Service
    {
        private readonly ILogger<Service> logger;

        public Service(ILogger<Service> logger)
        {
            this.logger = logger;
        }
        public void SendEmail()
        {
			try
			{
                MimeMessage message = new MimeMessage();
                message.From.Add(new MailboxAddress("D1msolinoGarant", "admin@mycompany.com"));
                message.To.Add(new MailboxAddress("iprusevich@gmail.com"));
                message.Subject = "Открытая тема";
                message.Body = new BodyBuilder() { HtmlBody = "<div style=\"color: green;\">Ленковский пидорас</div>" }.ToMessageBody();

                using (MailKit.Net.Smtp.SmtpClient client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 465, true); 
                    client.Authenticate("iwannaparadise@gmail.com", "7Q9xzU9EFjKZ3QM"); 
                    client.Send(message);

                    client.Disconnect(true);
                    logger.LogInformation("Сообщение отправлено успешно!");
                }
            }
            catch (Exception e)
            {
                logger.LogError(e.GetBaseException().Message);
            }
        }
    }
}
