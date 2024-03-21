using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_BookStore.Model;
using E_BookStore.DataLayer;
using E_BookStore.DataLayerSqlProvider;

namespace E_BookStore.BusinessLayer
{
    public static class CategoryandSubcategoryManager
    {
       // Category
        public static long AddNewCategory(CategoryModel category)
        {
            CategoryandSubcategorySQLProvider provider = new CategoryandSubcategorySQLProvider();
            var id = provider.AddNewCategory(category);
            return id;
        }
        public static bool UpdateCategory(CategoryModel category)
        {
            CategoryandSubcategorySQLProvider provider = new CategoryandSubcategorySQLProvider();
            var update = provider.UpdateCategory(category);
            return update;
        }
        public static bool DeleteCategory(int categoryid)
        {
            CategoryandSubcategorySQLProvider provider = new CategoryandSubcategorySQLProvider();
            var delete = provider.DeleteCategory(categoryid);
            return delete;
        }
        public static List<CategoryModel> GetAllCategories()

        {
            CategoryandSubcategorySQLProvider provider = new CategoryandSubcategorySQLProvider();
            var categories = provider.GetCategories();
            return categories;
        }
        public static CategoryModel GetCategory(int categoryid)
        {
            CategoryandSubcategorySQLProvider provider = new CategoryandSubcategorySQLProvider();
            var category = provider.GetCategory(categoryid);
            return category;
        }

       // Subcategory
        public static long AddNewSubCategory(SubCategoryModel subcategory)
        {
            CategoryandSubcategorySQLProvider provider = new CategoryandSubcategorySQLProvider();
            var id = provider.AddNewSubCategory(subcategory);
            return id;
        }
        public static bool UpdateSubCategory(SubCategoryModel subcategory)
        {
            CategoryandSubcategorySQLProvider provider = new CategoryandSubcategorySQLProvider();
            var update = provider.UpdateSubCategory(subcategory);
            return update;
        }
        public static bool DeleteSubCategory(int categoryid)
        {
            CategoryandSubcategorySQLProvider provider = new CategoryandSubcategorySQLProvider();
            var delete = provider.DeleteCategory(categoryid);
            return delete;
        }
        public static List<SubCategoryModel> GetAllSubCategories()
        {
            CategoryandSubcategorySQLProvider provider = new CategoryandSubcategorySQLProvider();
            var categories = provider.GetSubCategories();
            return categories;
        }
        public static SubCategoryModel GetSubCategory(int categoryid)
        {
            CategoryandSubcategorySQLProvider provider = new CategoryandSubcategorySQLProvider();
            var category = provider.GetSubCategory(categoryid);
            return category;
        }
    }
}
