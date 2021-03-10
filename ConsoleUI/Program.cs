using Business.Concrete;
using DataAccess.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("CarId:" + car.Id + " BrandId:" + car.BrandId + " ColorId:" + car.ColorId + " ModelName:" + car.ModelYear + " ModelYear:" + car.ModelYear + " DailyPrice:" + car.DailyPrice + " Description:" + car.Description);
            }




        }
    }
}
