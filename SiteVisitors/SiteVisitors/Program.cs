using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SiteVisitors
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteDatabase database = new RemoteDatabase();
            database.Add();
            SiteVisitors(database);
            VisitInfo(database);

            Console.ReadKey();
        }

        private static  void SiteVisitors(RemoteDatabase database)
        {
            List<User> users = new List<User>();
            for (int i = 0; i < 10; i++)
                users.Add(new User());
            foreach(User user in users)
            {
                 var thread = new Thread(() =>
                {
                    lock (user)
                    {
                        Random pageCount = new Random();
                        for (int j = 0; j < pageCount.Next(1, 10); j++)
                        {

                            Random pageNum = new Random();
                            int numPage = pageNum.Next(0, database.GetPages);
                            database.AddVisitForCurrentPage(database.pages[numPage]);
                            database.SetViews();
                            Console.WriteLine($"User {user.userId} have just visited page {database.pages[numPage].name}");
                        }
                    }                    
                });
                thread.Start();
                
            }
            
        }
        private static async void VisitInfo(RemoteDatabase database)
        {
            Thread.Sleep(200);
            foreach (Page page in database.pages)
            {
                Console.WriteLine("*****************");
                Console.WriteLine($"Page \"{page.name}\" has been visited for {page.GetViews} times");
            }
            Console.WriteLine("Current amount of views: {0}", database.GetViews);

        }
    }
}
