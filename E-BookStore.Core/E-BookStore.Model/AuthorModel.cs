using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_BookStore.Model
{
    public class AuthorModel
    {
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
        public string AuthorDivision { get; set; }
        public string AuthorArea { get; set; }
        public string AuthorAddress { get; set; }
        public string AuthorPhoneNumber { get; set; }
        public string AuthorEmail { get; set; }
        public string AuthorBIO { get; set; }
        public string AuthorFacebookPageUrl { get; set; }
        public string AuthorPageUrl { get; set; }
        public string AuthorImage { get; set; }
        public int PublisherID { get; set; }
        public int UserID { get; set; }
    }
}
