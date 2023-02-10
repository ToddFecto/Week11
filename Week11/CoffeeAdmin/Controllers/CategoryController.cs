using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeAdmin.Models;

namespace CoffeeAdmin.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            // there's a page you want to make available to only logged-in users,
            // you could do something like this in the controller:
            if (DAL.CurrentUser == null)
            {
                return Redirect("/");
            }
            List<Category> cats = DAL.GetAllCategories();
            return View(cats);
        }

        public IActionResult DeleteCategory(string catid)
        {
            return Content(catid);
        }

        /*
         * This is for a form that lets you add a new category.
         * I have two actions: one that displays the form, and one that gets called when the user submits the form.
         * That second one does the actual inserting into the database. I'm using the technique I mentioned earlier
         * to make sure the user is logged in before they can add a category. And then in the DAL I'm setting the 
         * username to the currently-logged-in user.
           Here are the two actions in the CategoryController:
         */
        public IActionResult AddCategoryForm()
        {
            if (DAL.CurrentUser == null)
            {
                return Redirect("/");
            }
            // This action repsents the user with a form for adding a new category
            return View();
        }

        [HttpPost]
        public IActionResult SaveCategory(Category cat)
        {
            if (DAL.CurrentUser == null)
            {
                return Redirect("/");
            }
            // This action saves the category after a user filled in the form from AddCategoryForm
            DAL.InsertCategory(cat);
            return Redirect("/Category");
        }
    }
}
