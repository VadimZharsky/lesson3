using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteVisitors
{
    class User
    {
        public  int userId;
        private static int _userId;

        public User()
        {
            _userId++;
            userId = _userId;
        }
    }
}
