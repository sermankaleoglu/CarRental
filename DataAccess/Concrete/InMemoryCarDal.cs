using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{Id = 1, BrandId = 1, ColorId = 1, DailyPrice =400, Description = "Electronic", ModelYear =2020},
                new Car{Id = 2, BrandId = 1, ColorId = 2, DailyPrice =650, Description = "Hybrit", ModelYear =2019},
                new Car{Id = 3, BrandId = 2, ColorId = 3, DailyPrice =470, Description = "Otomatic", ModelYear =2020},
                new Car{Id = 4, BrandId = 2, ColorId = 2, DailyPrice =250, Description = "Manuel", ModelYear =2020},
                new Car{Id = 5, BrandId = 3, ColorId = 1, DailyPrice =200, Description = "PickUp", ModelYear =2020},
                new Car{Id = 6, BrandId = 3, ColorId = 3, DailyPrice =500, Description = "Caravan", ModelYear =2020},
                new Car{Id = 7, BrandId = 4, ColorId = 1, DailyPrice =300, Description = "Commercial", ModelYear =2020},
            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c => c.Id == car.Id);
            _car.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int Id)
        {
            return _car.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

        }
    }
}
