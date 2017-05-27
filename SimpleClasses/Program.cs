//prep work day 5 and 8
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>() {
            new Car() {VIN="A1", Make="Honda", Model="Accord", StickerPrice=35000, Year=2006,Color="blue"},
            new Car() {VIN="B2", Make="Honda", Model="Africa Twin", StickerPrice=15000, Year=2008,Color="red"},
            new Car() {VIN="C3", Make="Honda", Model="Civic", StickerPrice=25000, Year=2016,Color="green"},
            new Car() {VIN="D4", Make="Ford", Model="Escape", StickerPrice=55000, Year=2012,Color="black"},
            new Car() {VIN="E5", Make="Chevy", Model="Corvette", StickerPrice=45000, Year=2014,Color="orange"},
            };

            //LINQ query
            var hondasq = from car in myCars where car.Make == "Honda" && car.Year==2006 select car;
            var orderedCarsQ = from car in myCars orderby car.Year descending select car;
            var anonType = from car in myCars where car.Make == "Honda" select new { car.Make, car.Model };

            //LINQ method
            var hondasm = myCars.Where(car => car.Make == "Honda" && car.Year == 2006);
            var orderedCarsM = myCars.OrderByDescending(car => car.Year);
            var firstHonda = myCars.First(car => car.Make == "Honda");
            var firstDesc = myCars.OrderByDescending(car => car.Year).First(car => car.Make == "Honda");

            foreach (var car in hondasq)
            {
                Console.WriteLine("query honda: {0} {1}", car.Model, car.VIN);
            }

            foreach (var car in hondasm)
            {
                Console.WriteLine("method honda: {0} {1}", car.Model, car.VIN);
            }

            foreach (var car in orderedCarsQ)
            {
                Console.WriteLine("query ordered: {0} {1} {2}", car.Model, car.VIN, car.Year);
            }

            foreach (var car in orderedCarsM)
            {
                Console.WriteLine("method ordered: {0} {1} {2}", car.Model, car.VIN, car.Year);
            }

            Console.WriteLine("firstHonda: {0}", firstHonda.VIN);
            Console.WriteLine("firstOrdered: {0}", firstDesc.VIN);
            Console.WriteLine(myCars.TrueForAll(p => p.Year > 2011));
            Console.WriteLine(myCars.TrueForAll(p => p.Year > 2005));
            myCars.ForEach(car => car.StickerPrice -= 3000);
            myCars.ForEach(car => Console.WriteLine("sticker price: {0} {1}", car.VIN, car.StickerPrice));
            Console.WriteLine(myCars.Exists(car => car.Model == "Civic"));
            Console.WriteLine(myCars.Sum(car => car.StickerPrice));
            Console.WriteLine(myCars.GetType());
            Console.WriteLine(orderedCarsM.GetType());
            Console.WriteLine(orderedCarsQ.GetType());

            foreach (var car in anonType)
            {
                Console.WriteLine("anonType: {0} {1}", car.Make, car.Model);
            }
            Console.WriteLine(anonType.GetType());

            Console.ReadLine();
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public int StickerPrice { get; set; }
    }
}
