using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //GetCars(carManager);
            //CarByBrandId(carManager);
            //CarByColorId(carManager);
            carManager.Add(new Car
            {
                ColorId = 1,
                CarName = "Peu",
                DailyPrice = 0,
                Description = "good",
                ModelYear = 2010,
                CarId = 4,                
                BrandId = 3
            }); Console.ReadLine();
        }

        private static void CarByColorId(CarManager carManager)
        {
            foreach (var car in carManager.GetCarsByColorId(3))
            {
                Console.WriteLine(car.CarId + " - " + car.CarName + " - " + car.DailyPrice + " - " + car.ModelYear + " - " + car.ColorId + " - " + car.BrandId + " - " + car.Description);
            }
        }

        private static void CarByBrandId(CarManager carManager)
        {
            foreach (var car in carManager.GetCarsByBrandId(3))
            {
                Console.WriteLine(car.CarId + " - " + car.CarName + " - " + car.DailyPrice + " - " + car.ModelYear + " - " + car.ColorId + " - " + car.BrandId + " - " + car.Description);
            }
        }

        private static void GetCars(CarManager carManager)
        {
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId + " - " + car.CarName + " - " + car.DailyPrice + " - " + car.ModelYear + " - " + car.ColorId + " - " + car.BrandId + " - " + car.Description);
            }
        }
    }
}
