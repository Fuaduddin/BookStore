using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_BookStore.Model
{
    public class SuperAdminandAdminViewModel
    {
        public CategoryModel Category { get; set; }
        public SubCategoryModel SubCategory { get; set; }

        // All List

        public List<CategoryModel> CategoryList { get; set; }
        public List<SubCategoryModel> SubCategoryList { get; set; }
    }
}
