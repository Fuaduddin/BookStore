//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace E_BookStore.Utility.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Borrow
    {
        public int BorrowID { get; set; }
        public int BookID { get; set; }
        public int CusomerID { get; set; }
        public System.DateTime BorrowDate { get; set; }
        public System.DateTime ReturnDate { get; set; }
        public Nullable<int> ReturnUpdate { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual Customer Customer { get; set; }
    }
}