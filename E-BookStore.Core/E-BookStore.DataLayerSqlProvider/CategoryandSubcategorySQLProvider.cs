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
using E_BookStore.Utility.DataBase;
using E_BookStore.Utility;

namespace E_BookStore.DataLayerSqlProvider
{
    public class CategoryandSubcategorySQLProvider : ICategoryandSubcategoryDatalayer
    {
        private static readonly Entity DatabaseProvider;
        // Category
        public long AddNewCategory(CategoryModel category)
        {
            long CategoryID = 0;
            if(category != null)
            {
                try
                {
                    var DBcategory = new Category()
                    {
                        CategoryName = category.CategoryName
                    };
                    //var DBcategory = new Category();
                    //DBcategory.CategoryName = category.CategoryName;
                    //DBcategory.SubCategories =new List<SubCategory>();
                    DatabaseProvider._dbContext.Categories.Add(DBcategory);
                    DatabaseProvider._dbContext.SaveChanges();
                    CategoryID = DBcategory.CategoryID;
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
                    var CategoryDetails = DatabaseProvider._dbContext.Categories.Where(x => x.CategoryID == category.CategoryID).FirstOrDefault();
                    if (CategoryDetails != null)
                    {
                        CategoryDetails.CategoryName = category.CategoryName;
                        DatabaseProvider._dbContext.SaveChanges();
                    }
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
            //try
            //{
            //    CategoryList = DatabaseProvider._dbContext.Categories.Select(x => new CategoryModel()
            //    {
            //        CategoryID = x.CategoryID,
            //        CategoryName = x.CategoryName
            //    }).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception(ex.ToString());
            //}
            return CategoryList;
        }
        public bool DeleteCategory(int id)
        {
            bool IsDeleted = true;
            if (id > 0)
            {
                try
                {
                    var CategoryDetails = DatabaseProvider._dbContext.Categories.Where(x => x.CategoryID == id).FirstOrDefault();
                    DatabaseProvider._dbContext.Categories.Remove(CategoryDetails);
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
                    category=DatabaseProvider._dbContext.Categories.Select(x=> new CategoryModel()
                    {
                        CategoryID= x.CategoryID,
                        CategoryName= x.CategoryName
                    }).Where(x=>x.CategoryID==id).FirstOrDefault();
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
                    var Subcategory = new SubCategory()
                    {
                        SubcategoryName = subcategory.SubcategoryName,
                        //CategoryID = subcategory.CategoryID
                    };
                    DatabaseProvider._dbContext.SubCategories.Add(Subcategory);
                    SubcategoryID = Subcategory.SubCategoryID;
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
                    var SubcategoryDetails=DatabaseProvider._dbContext.SubCategories.Where(x=>x.SubCategoryID==subcategory.SubCategoryID).FirstOrDefault();
                    if(SubcategoryDetails != null)
                    {
                        SubcategoryDetails.SubcategoryName= subcategory.SubcategoryName;
                        //SubcategoryDetails.CategoryID = subcategory.CategoryID;
                        DatabaseProvider._dbContext.SaveChanges();
                    }
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
                SubCategoryList = DatabaseProvider._dbContext.SubCategories.Select(Subcategory => new SubCategoryModel()
                {
                    SubCategoryID = Subcategory.SubCategoryID,
                    SubcategoryName = Subcategory.SubcategoryName,
                    //CategoryDetails =(CategoryModel)DatabaseProvider.Categories.Where(category => category.CategoryID == Subcategory.CategoryID).FirstOrDefault()
                }).ToList();
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
                    var SubcategoryDetails = DatabaseProvider._dbContext.SubCategories.Where(x => x.SubCategoryID == id).FirstOrDefault();
                    DatabaseProvider._dbContext.SubCategories.Remove(SubcategoryDetails);
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
                    //Subcategory = (SubCategoryModel) DatabaseProvider.SubCategories.Where(x => x.SubCategoryID == id).FirstOrDefault();
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
