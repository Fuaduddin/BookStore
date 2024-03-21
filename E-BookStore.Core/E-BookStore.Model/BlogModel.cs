using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_BookStore.Model
{
    public class BlogModel
    {
        public int BlogID { get; set; }
        public string BlogTitle { get; set; }
        public string BlogDetails { get; set; }
        public string BlogImage { get; set; }
        public int BloggerID { get; set; }
        public DateTime PublishedDate { get; set; }
    }
}
