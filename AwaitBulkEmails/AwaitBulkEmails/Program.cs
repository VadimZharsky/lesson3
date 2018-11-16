using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwaitBulkEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Mail> mails = new List<Mail>();
            mails.Add(new Mail("mail#1"));
            mails.Add(new Mail("mail#2"));
            mails.Add(new Mail("mail#3"));

            foreach (Mail mail in mails)
            {
                SmrtServer.SendEmail(mail);
            }
            Console.ReadLine();
        }
    }
}
