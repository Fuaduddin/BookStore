using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_BookStore.Model
{
    public  class BloggerModel
    {
        public int BloggerID { get; set; }
        public string BloggerName { get; set; }
        public string BloggerAddress { get; set; }
        public string BloggerDivision { get; set; }
        public string BloggerArea { get; set; }
        public string BloggerPhoneNumber { get; set; }
        public string BloggerEmail { get; set; }
        public string BloggerImage { get; set; }
        public string BloggerBio { get; set; }
        public string BloggerPageUrl { get; set; }
        public int UserID { get; set; }
    }
}
