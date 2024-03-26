using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_BookStore.Model
{
    public class CategoryandSubcategoryModel
    { }
    public class CategoryModel
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public List<SubCategoryModel> SubCategories { get; set; }
    }
    public class SubCategoryModel
    {
        public int SubCategoryID { get; set; }
        public string SubcategoryName { get; set; }
        public int CategoryID { get; set; }
        public CategoryModel CategoryDetails { get; set; }
    }
}
