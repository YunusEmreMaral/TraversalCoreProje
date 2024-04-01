using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(MailRequest mailRequest)
        {
            MimeMessage mimeMessage = new MimeMessage();

<<<<<<< HEAD
            MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "traversaltraversal@gmail.com");
=======
            MailboxAddress mailboxAddressFrom = new MailboxAddress("Traversal Core", "coretraversal@gmail.com");
>>>>>>> 310f0bbc7b07f1810adab3aa5ebf3afa76c4dedf
            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", mailRequest.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);

            mimeMessage.Subject = mailRequest.Subject;

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = mailRequest.Body;
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
<<<<<<< HEAD
            client.Authenticate("traversaltraversal@gmail.com", "qrfmmblgyssbrlnu");
=======
            client.Authenticate("maralyunusemre41@gmail.com", "Yunusemre5441@");
>>>>>>> 310f0bbc7b07f1810adab3aa5ebf3afa76c4dedf

            client.Send(mimeMessage);
            client.Disconnect(true);

            return RedirectToAction("Mail","Admin");
        }
    }
}
