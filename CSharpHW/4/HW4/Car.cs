using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    class Car
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public Car(string model, int year, string color)
        {
            this.Model = model;
            this.Year = year;
            this.Color = color;
        }
    }
}
