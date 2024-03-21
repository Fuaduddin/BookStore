using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E_BookStore.BusinessLayer;
using E_BookStore.Model;

namespace E_BookStore.AdminPanel.Controllers
{
	public class CategoryController : Controller
	{
		[Route("category")]
		public ActionResult Index()
		{
            SuperAdminandAdminViewModel category= new SuperAdminandAdminViewModel();
            category.Category= new CategoryModel();
         //   category.CategoryList = CategoryandSubcategoryManager.GetAllCategories();
			return View("Index", category);
		}
		[HttpPost]
        public ActionResult AddNewCategory(CategoryModel category)
        {
			if(category.CategoryID>0)
			{
				if(CategoryandSubcategoryManager.UpdateCategory(category))
				{
                    ViewData["Message"] = "Your data have  been Updated";
                    ModelState.Clear();
                }
				else
				{
                    ViewData["Message"] = "!!!!!!!!! Error !!!!!!!!!!";
                }
			}
			else
			{
				if(ModelState.IsValid)
				{
                    if (CategoryandSubcategoryManager.AddNewCategory(category) > 0)
                    {
                        ViewData["Message"] = "Your data have  been Added";
                        ModelState.Clear();
                    }
					else
					{
                        ViewData["Message"] = "!!!!!!!!! Error !!!!!!!!!!";
                    }
				}
			}
            return View("category");
        }
        public ActionResult DeleteCategroy(int id)
        {
			if(id > 0)
			{
				if(CategoryandSubcategoryManager.DeleteCategory(id)) 
				{
                    ViewData["Message"] = "Your data have  been Deleted";
                }
                else
                {
                    ViewData["Message"] = "!!!!!!!!! Error !!!!!!!!!!";
                }
            }
            return View("category");
        }
        public ActionResult GetSingleCategory(int id)
        {
            CategoryModel category= new CategoryModel();
            if(id>0)
            {
                category=CategoryandSubcategoryManager.GetCategory(id);
            }
            return View("category", category);
        }







        //// Sub Category 
        [Route("SubCategory")]
        public ActionResult SubCategory()
        {
            SuperAdminandAdminViewModel category = new SuperAdminandAdminViewModel();
            category.Category = new CategoryModel();
            category.CategoryList = CategoryandSubcategoryManager.GetAllCategories();
            return View("category", category);
        }
        [HttpPost]
        public ActionResult AddNewSubCategory(CategoryModel category)
        {
            if (category.CategoryID > 0)
            {
                if (CategoryandSubcategoryManager.UpdateCategory(category))
                {
                    ViewData["Message"] = "Your data have  been Updated";
                    ModelState.Clear();
                }
                else
                {
                    ViewData["Message"] = "!!!!!!!!! Error !!!!!!!!!!";
                }
            }
            else
            {
                if (ModelState.IsValid)
                {
                    if (CategoryandSubcategoryManager.AddNewCategory(category) > 0)
                    {
                        ViewData["Message"] = "Your data have  been Added";
                        ModelState.Clear();
                    }
                    else
                    {
                        ViewData["Message"] = "!!!!!!!!! Error !!!!!!!!!!";
                    }
                }
            }
            return View("category");
        }
        public ActionResult DeleteSubCategory(int id)
        {
            if (id > 0)
            {
                if (CategoryandSubcategoryManager.DeleteCategory(id))
                {
                    ViewData["Message"] = "Your data have  been Deleted";
                }
                else
                {
                    ViewData["Message"] = "!!!!!!!!! Error !!!!!!!!!!";
                }
            }
            return View("category");
        }
        public ActionResult GetSingleSubCategory(int id)
        {
            CategoryModel category = new CategoryModel();
            if (id > 0)
            {
                category = CategoryandSubcategoryManager.GetCategory(id);
            }
            return View("category", category);
        }

    }
}
