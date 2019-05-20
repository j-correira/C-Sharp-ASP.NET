using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; //allows us to set the primairy key

namespace firstMVC.Models
{
    public class Car
    {

        //car properties
        [Key]
        public int Car_ID { get; set; }
        public string Model { get; set; }
        public double MaxSpeed { get; set; }
    }
}