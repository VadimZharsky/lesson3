using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteVisitors
{
    class RemoteDatabase : IDisposable
    {
        private int _views;
        private static int _pages;
        public List<Page> pages = new List<Page>();


        public void Add()
        {
            List<Page> Addedpages = new List<Page>();
            Addedpages.Add(new Page("mainPage"));
            Addedpages.Add(new Page("helper"));
            Addedpages.Add(new Page("contacts"));
            Addedpages.Add(new Page("about"));
            Addedpages.Add(new Page("currentNews"));
            Addedpages.Add(new Page("Items"));
            Addedpages.Add(new Page("feedBack"));
            pages = Addedpages;
            _pages = pages.Count;
        }

        public virtual int GetViews
        {
            get { return _views; }
        }
        public int GetPages
        {
            get { return _pages; }
        }

        public void AddVisitForCurrentPage(Page page)
        {
            page.AddViews();
        }

        public void SetViews()
        {
            _views++;
        }
        public void Dispose()
        {
            GC.Collect();
        }

    }
    class Page : RemoteDatabase
    {
        public string name;
        private int _Views;
        public Page(string name)
        {
            this.name = $"RemoteDatabase/{name}";
        }
        public void AddViews()
        {
            SetViews();
            _Views++;
        }

        public override int GetViews
        {
            get { return _Views; }
        }
    }
}
