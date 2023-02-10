using Assessment8_FOC_Potluck_MySql.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment8_FOC_Potluck_MySql.Controllers
{
    public class FocPotluck : Controller
    {
        // TeamMember Section
        // READ TeamMember/RSVP Section (CRUD "R")
        public IActionResult Index()
        {
            List<TeamMember> tms = DAL.GetAllTeamMembers();
            return View(tms);
        }

        public IActionResult teammember(int tm)
        {
            TeamMember thetm = DAL.GetTeammember(tm);
            return View(thetm);
        }
        // Create then INSERT TM Form (RSVP - CRUD "C")
        public IActionResult RSVP()
        {
            return View();
        }

        // Confirmation Page After INSERT
        [HttpPost]
        public IActionResult RSVPThankYou(TeamMember rSVP)
        {
            if (rSVP.FirstName == null || rSVP.FirstName.Length < 2)
            {
                ViewData["Message"] = "***Please provide your full first name. Please try again.***";
                return View("RSVP");
            }
            if (rSVP.LastName == null || rSVP.LastName.Length < 1)
            {
                ViewData["Message"] = "***Last name needs at least one character. Please try again.***";
                return View("RSVP");
            }
            else if (rSVP.EmailAddress == null || !rSVP.EmailAddress.Contains("@"))
            {
                ViewData["Message"] = "***Please provide a valid email address.***";
                return View("RSVP");
            }
            else if (rSVP.AttendanceDate == null)
            {
                ViewData["Message"] = "***Please choose a date to attend.***";
                return View("RSVP");
            }
            else if (rSVP.GuestName == null)
            {
                ViewData["Message"] = "***Please provide a guest name or enter 'NA' if attending alone.***";
                return View("RSVP");
            }
            else
            {
                DAL.InsertTeammember(rSVP);
                return View(rSVP);
            }
        }

        // Edit then UPDATE TM Form (RSVP - CRUD "U")
        public IActionResult editTMform(int tmid)
        {
            TeamMember tm = DAL.GetTeammember(tmid);
            return View(tm);
        }

        // UPDATE TM then Return to All TM's List
        public IActionResult savetm(TeamMember tm)
        {
            if (tm.FirstName == null || tm.FirstName.Length < 2)
            {
                ViewData["Message"] = "***Please provide your full first name. Please try again.***";
                return View("RSVP");
            }
            else if (tm.LastName == null || tm.LastName.Length < 1)
            {
                ViewData["Message"] = "***Last name needs at least one character. Please try again.***";
                return View("RSVP");
            }
            else if (tm.EmailAddress == null || !tm.EmailAddress.Contains("@"))
            {
                ViewData["Message"] = "***Please provide a valid email address.***";
                return View("RSVP");
            }
            else if (tm.AttendanceDate == null || tm.AttendanceDate.Length < 1)
            {
                ViewData["Message"] = "***Please choose a date to attend.***";
                return View("RSVP");
            }
            else if (tm.GuestName == null)
            {
                ViewData["Message"] = "***Please provide a guest name or enter 'NA' if attending alone.***";
                return View("RSVP");
            }
            else
            {
                DAL.UpdateTeammember(tm);
                return Redirect($"/FoCPotluck/Index");
            }
        }

        // DELETE TM Form (RSVP - CRUD "D")
        public IActionResult deletetm(int id)
        {
            DAL.DeleteTM(id);
            return Redirect($"/FoCPotluck/Index");
        }


        // Dish Section

        // READ TeamMember/RSVP Section (CRUD "R")
        public IActionResult ListAllDishes()
        {
            List<Dish> dishes = DAL.GetAllDishes();
            return View(dishes);
        }

        public IActionResult ListDish(int dish)
        {
            Dish thedish = DAL.GetDish(dish);
            return View(thedish);
        }

        // Create then INSERT Dish Form (Dish - CRUD "C")
        public IActionResult BringADish()
        {
            return View();
        }

        // Confirmation Page After INSERT
        [HttpPost]
        public IActionResult DishThankYou(Dish bringADish)
        {
            if (bringADish.TMName == null)
            {
                ViewData["Message"] = "***Please fill in the name field.***";
                return View("BringADish");
            }
            else if (bringADish.DishName == null || bringADish.DishName.Length < 2)
            {
                ViewData["Message"] = "***Please provide a valid name, for your dish. Thank you.***";
                return View("BringADish");
            }
            else if (bringADish.DishDescription == null)
            {
                ViewData["Message"] = "***Please provide a short description, for what you are bringing. Thank you.***";
                return View("BringADish");
            }
            else if (bringADish.Category == null)
            {
                ViewData["Message"] = "***Please choose a Category for a dish.***";
                return View("BringADish");
            }
            else
            {
                DAL.InsertDish(bringADish);
                return View(bringADish);
            }
        }

        // Edit then UPDATE Dish Form (Dish - CRUD "U")
        public IActionResult editDishform(int dishid)
        {
            Dish dish = DAL.GetDish(dishid);
            return View(dish);
        }
        public IActionResult savedish(Dish bringADish)
        {
            if (bringADish.TMName == null)
            {
                ViewData["Message"] = "***Please fill in the name field.***";
                return View("BringADish");
            }
            else if (bringADish.DishName == null || bringADish.DishName.Length < 2)
            {
                ViewData["Message"] = "***Please provide a valid name, for your dish. Thank you.***";
                return View("BringADish");
            }
            else if (bringADish.DishDescription == null)
            {
                ViewData["Message"] = "***Please provide a short description, for what you are bringing. Thank you.***";
                return View("BringADish");
            }
            else if (bringADish.Category == null)
            {
                ViewData["Message"] = "***Please choose a Category for a dish.***";
                return View("BringADish");
            }
            else
            {
                DAL.UpdateDish(bringADish);
                return Redirect($"/FoCPotluck/ListAllDishes");
            }
        }

        // DELETE TM Form (RSVP - CRUD "D")
        public IActionResult deletedish(int id)
        {
            DAL.DeleteDish(id);
            return Redirect($"/FoCPotluck/ListAllDishes");
        }
    }
}
