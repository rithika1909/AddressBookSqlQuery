using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSqlQuery
{
    public class Contact
    {
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zip { get; set; }
        public string phonenumber { get; set; }
        public string email { get; set; }
        public int count { get; set; }
        public string type { get; set; }
    }
}
