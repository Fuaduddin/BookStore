using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_BookStore.Model
{
    public class CustomerModel
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerImage { get; set; }
        public string CustomerDivision { get; set; }
        public string CustomerArea { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public int UserID { get; set; }
    }
}
