using E_BookStore.Utility.DataBase;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace E_BookStore.Utility
{
    public class Entity
    {
        public readonly DatabaseConnection _dbContext;

        public Entity(DatabaseConnection dbContext)
        {
            _dbContext = dbContext;
        }
    }
    public class DatabaseConnection : DbContext
    {
        public DatabaseConnection() : base()
        {

        }
        public virtual DbSet<AssignmentJournal> AssignmentJournals { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Blogger> Bloggers { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BookOrderAssign> BookOrderAssigns { get; set; }
        public virtual DbSet<Borrow> Borrows { get; set; }
        public virtual DbSet<BuyBook> BuyBooks { get; set; }
        public virtual DbSet<BuyJournal> BuyJournals { get; set; }
        public virtual DbSet<BuyJournalList> BuyJournalLists { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<DeliveryMan> DeliveryMen { get; set; }
        public virtual DbSet<Journal> Journals { get; set; }
        public virtual DbSet<OrderBookList> OrderBookLists { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<SubCategory> SubCategories { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
