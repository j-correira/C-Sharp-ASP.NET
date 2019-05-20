using firstMVC.Models;  //directly reference car class
using System.Web.Mvc;   //using select list item
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace firstMVC.ViewModels.Home
{
    public class CarsListViewModel
    {
        //list of cars
        public IEnumerable<SelectListItem> CarsList { get; private set; }

        //instance of fastest car
        public Car FastestCar { get; set; }

        //constructor
        public CarsListViewModel(IEnumerable<Car> cars)
        {
            CarsList = cars.Select(c => new SelectListItem() { Text = c.Model });

            //pointer to fastest car
            FastestCar = cars.OrderByDescending(c => c.MaxSpeed).FirstOrDefault();
        }
    }
}