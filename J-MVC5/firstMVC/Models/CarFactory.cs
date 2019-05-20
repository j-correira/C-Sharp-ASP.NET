using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity; //aloows use to use DB context

namespace firstMVC.Models
{
    public class CarFactory : DbContext //inherits the db connect so Entity can manage DB
    {
        public DbSet<Car> Cars { get; set; }

        public CarFactory()
        {
            Database.SetInitializer(new CarInitializer());
        }
    }

    public class CarInitializer: DropCreateDatabaseIfModelChanges<CarFactory>
    {
        protected override void Seed(CarFactory context) //seeds the table
        {
            {
                context.Cars.Add(new Models.Car() { Model = "Rabbit", MaxSpeed = 300 });
                context.Cars.Add(new Models.Car() { Model = "Squirrel", MaxSpeed = 999 });
                context.Cars.Add(new Models.Car() { Model = "Turtle", MaxSpeed = 5 });
                context.Cars.Add(new Models.Car() { Model = "Elephant", MaxSpeed = 200 });
                context.Cars.Add(new Models.Car() { Model = "Sloth", MaxSpeed = 1 });
            }
        }
    }
}