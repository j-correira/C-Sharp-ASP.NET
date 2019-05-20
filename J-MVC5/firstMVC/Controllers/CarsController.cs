using firstMVC.Models;  //use CarsFactory Class
using firstMVC.ViewModels.Home;  //use view models
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace firstMVC.Controllers
{
    public class CarsController : Controller
    {
        // GET: Cars
        public ActionResult CarsList()
        {
            //factory -. new instance of CarFactory model
            var factory = new CarFactory();

            //viewmodel -> fill viewmodel with the cars list
            var viewModel = new CarsListViewModel(factory.Cars);

            return View(viewModel);
        }
    }
}