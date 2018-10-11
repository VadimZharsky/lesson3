using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7_HomeWork_
{
    class Neighbour
    {
        private string fullName;
        private string flatNumber;
        private string phoneNumber;

        public string FullName
        {
            get { return fullName; }
            set { fullName = (value.Length > 0) ? value : "NONAME"; }
        }
        public string FlatNumber
        {
            get { return flatNumber; }
            set { flatNumber = (value.Length > 0) ? value : "not specified"; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = (value.Length > 0) ? value : "not specified"; }
        }
    }

}
