using MVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static DataLibrary.BusinessLogic.RecipeProcessor;

namespace MVCApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View("");
        }

        public ActionResult ViewRecipes()
        {
            ViewBag.Message = "Recipes list.";

            var data = LoadRecipe();
            List<RecipeModel> recipes = new List<RecipeModel>();
            foreach (var row in data)
            {
                recipes.Add(new RecipeModel
                {
                    FirstName = row.FirstName,
                    LastName = row.LastName,
                    Age = row.Age,
                    Address = row.Address,
                    MedicalRecords = row.MedicalRecords,
                    Diagnostic = row.Diagnostic,
                    Prescriptions = row.Prescriptions
                });

            }

            return View(recipes);
        }
        public ActionResult Recipe()
        {
            ViewBag.Message = "Your recipe page.";

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Recipe(RecipeModel model)
        {
            if(ModelState.IsValid)
            {
                CreateRecipe(model.FirstName, 
                    model.LastName, 
                    model.Age, 
                    model.Address,
                    model.MedicalRecords, 
                    model.Diagnostic, 
                    model.Prescriptions);
                return RedirectToAction("Index");
            }

            return View();
        }
        public ActionResult GeneratePDF()
        {
            return new Rotativa.ActionAsPdf("ViewRecipes");
        }
    }
}