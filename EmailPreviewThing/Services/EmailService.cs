using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace EmailPreviewThing.Services
{
    public class EmailService : IEmailService
    {
        public string GenerateEmailAndSave(string pdfLocation)
        {
            MailMessage emailMessage = new MailMessage();

            emailMessage.To.Add("kfong@rentsmartworld.com");
            emailMessage.From = new MailAddress("it@thinksmartworld.com");
            emailMessage.Subject = "Test Subject";
            emailMessage.Body = "Hi Kenny";
            emailMessage.Attachments.Add(new Attachment(pdfLocation));

            string emaillocation = @"c:\emails\test.eml";

            emailMessage.Save(emaillocation);

            return emaillocation;
        }

        public void Send(string emailLocation)
        {
        }
    }
}
