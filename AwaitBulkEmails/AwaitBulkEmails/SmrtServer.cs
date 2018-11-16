using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwaitBulkEmails
{
    class SmrtServer
    {
        public static async void SendEmail(Mail mail)
        {

           var res = await MailSender(mail);
            Console.WriteLine(res);
        }

        private static async Task<bool>  MailSender(Mail mail)
        {

            var task = new Task(() =>
            {
                Task.Delay(2000).Wait();
                Console.WriteLine($"{mail.body} sent");
                Console.WriteLine($" %%%%%%%%%%%%");
                
            });
            task.Start();
            task.Wait();
            bool succes = (task.IsCompleted) ? true : false;
            return succes;
        }
    }
}
