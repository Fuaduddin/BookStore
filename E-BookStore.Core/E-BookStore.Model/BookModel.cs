using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_BookStore.Model
{
    public class BookModel
    {
        public int BookID { get; set; }
        public string BookTitle { get; set; }
        public string BookDetails { get; set; }
        public string BookImage { get; set; }
        public int BookPrice { get; set; }
        public int SubCategoryID { get; set; }
        public int AuthorID { get; set; }
        public int PublisherID { get; set; }
        public DateTime PublishedDate { get; set; }

        public DateTime AddedDate { get; set; }
    }
}
