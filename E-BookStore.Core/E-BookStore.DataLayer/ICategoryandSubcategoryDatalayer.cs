using E_BookStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_BookStore.DataLayer
{
    public interface ICategoryandSubcategoryDatalayer
    {
        // Category
        long AddNewCategory(CategoryModel category);
        bool UpdateCategory(CategoryModel category);
        List<CategoryModel> GetCategories();
        bool DeleteCategory(int id);
        CategoryModel GetCategory(int id);


        // SubCategory
        long AddNewSubCategory(SubCategoryModel subcategory);
        bool UpdateSubCategory(SubCategoryModel subcategory);
        List<SubCategoryModel> GetSubCategories();
        bool DeleteSubCategory(int id);
        SubCategoryModel GetSubCategory(int id);

    }
}
