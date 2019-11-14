using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcBasic_Clone.Models;
using MvcBasic_Clone.ViewModels;

namespace MvcBasic_Clone.Controllers
{
    public class PassDataController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult PassViewData() 
        {
            ViewData["Name"] = "Kevin";         //string
            ViewData["Age"] = 33;               //int
            ViewData["Single"] = true;          //boolen
            return View();
        }

        public ActionResult PassViewBag() 
        {
          
            ViewBag.Nickname = "Mary";
            ViewBag.Height = 168;
            ViewBag.Weight = 52;
            ViewBag.Married = false;
            return View();
        }
        public ActionResult Petshop()
        {
            //via viewdata
            ViewData["Company"] = "PetshopOfTerror";
            ViewBag.Address = "Hell";

            List<string> PetsList = new List<string>();
            PetsList.Add("Dog");
            PetsList.Add("Cat");
            PetsList.Add("Fish");
            PetsList.Add("Mouse");
            PetsList.Add("Chameleon");

            return View(PetsList);
        
        }
        public ActionResult PassTempData()
        {
            TempData["ErrorMessage"] = "無足夠權限存取系統資料，請聯繫系統管理員";
            TempData["UserName"] = "David";
            TempData["Time"] = DateTime.Now.ToLongTimeString();
            return RedirectToAction("ErrorMessage", "ErrorHandler");
        }
        public ActionResult PassViewModel()
        {
            PeopleViewModels peopleVM = new PeopleViewModels();
            peopleVM.Employees = null;
            peopleVM.Friends = null;

            return View(peopleVM);
        }
    }
}