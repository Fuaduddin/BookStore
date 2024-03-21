using E_BookStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_BookStore.DataLayerSqlProvider;
using System.Data.SqlClient;
using E_BookStore.DataLayer;
using System.Data;
using E_BookStore.Utility.DB;

namespace E_BookStore.DataLayerSqlProvider
{
    public class CategoryandSubcategorySQLProvider : ICategoryandSubcategoryDatalayer
    {
        private static readonly Entities DatabaseProvider = new Entities();
        // Category
        public long AddNewCategory(CategoryModel category)
        {
            long CategoryID = 0;
            if(category != null)
            {
                try
                {

                }
                catch(Exception ex)
                {
                    throw new Exception(ex.ToString());
                }
            }
             return CategoryID;
        }
        public bool UpdateCategory(CategoryModel category)
        {
            bool IsUpdated = true;
            if (category.CategoryID>0)
            {
                try
                {

                }
                catch (Exception ex)
                {
                    IsUpdated = false;
                    throw new Exception(ex.ToString());
                }
            }
            return IsUpdated;
        }
        public List<CategoryModel> GetCategories()
        {
            List<CategoryModel> CategoryList = new List<CategoryModel>();
            try
            {

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return CategoryList;
        }
        public bool DeleteCategory(int id)
        {
            bool IsDeleted = true;
            if (id > 0)
            {
                try
                {

                }
                catch (Exception ex)
                {
                    IsDeleted = false;
                    throw new Exception(ex.ToString());
                }
            }
            return IsDeleted;
        }
        public CategoryModel GetCategory(int id)
        {
            CategoryModel category = new CategoryModel();
            if (id > 0)
            {
                try
                {

                }
                catch (Exception ex)
                {
                    throw new Exception(ex.ToString());
                }
            }
            return category;
        }

        // Subcategory

        public long AddNewSubCategory(SubCategoryModel subcategory)
        {
            long SubcategoryID = 0;
            if (subcategory != null)
            {
                try
                {

                }
                catch (Exception ex)
                {
                    throw new Exception(ex.ToString());
                }
            }
            return SubcategoryID;
        }
        public bool UpdateSubCategory(SubCategoryModel subcategory)
        {
            bool IsUpdated = true;
            if (subcategory.SubCategoryID > 0)
            {
                try
                {

                }
                catch (Exception ex)
                {
                    IsUpdated = false;
                    throw new Exception(ex.ToString());
                }
            }
            return IsUpdated;

        }
        public List<SubCategoryModel> GetSubCategories()
        {
            List<SubCategoryModel> SubCategoryList = new List<SubCategoryModel>();
            try
            {

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return SubCategoryList;
        }
        public bool DeleteSubCategory(int id)
        {
            bool IsDeleted = true;
            if (id > 0)
            {
                try
                {

                }
                catch (Exception ex)
                {
                    IsDeleted = false;
                    throw new Exception(ex.ToString());
                }
            }
            return IsDeleted;

        }
        public SubCategoryModel GetSubCategory(int id)
        {
            SubCategoryModel Subcategory = new SubCategoryModel();
            if (id > 0)
            {
                try
                {

                }
                catch (Exception ex)
                {
                    throw new Exception(ex.ToString());
                }
            }
            return Subcategory;

        }
    }
}
