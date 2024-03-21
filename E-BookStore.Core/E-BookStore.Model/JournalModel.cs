using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_BookStore.Model
{
    public class JournalModel
    {
        public int JournalID { get; set; }
        public string JournalTitle { get; set; }
        public string JournalDetails { get; set; }
        public string JournalImage { get; set; }
        public int JournalPrice { get; set; }
        public int SubCategoryID { get; set; }
        public int PublisherID { get; set; }
        public DateTime PublishedDate { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
