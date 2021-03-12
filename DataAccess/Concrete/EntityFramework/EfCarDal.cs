using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car car)
        {
            using (CarRentalContext carRentalContext = new CarRentalContext())
            {
                var addedContext = carRentalContext.Entry(car);
                addedContext.State = EntityState.Added;
                carRentalContext.SaveChanges();
            }
        }

        public void Delete(Car car)
        {
            using (CarRentalContext carRentalContext = new CarRentalContext())
            {
                var deletedContext = carRentalContext.Entry(car);
                deletedContext.State = EntityState.Deleted;
                carRentalContext.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (CarRentalContext carRentalContext = new CarRentalContext())
            {
                return carRentalContext.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (CarRentalContext carRentalContext = new CarRentalContext())
            {
                return filter == null ? carRentalContext.Set<Car>().ToList()
                    : carRentalContext.Set<Car>().Where(filter).ToList();
            }
        }

        public void Update(Car car)
        {
            using (CarRentalContext carRentalContext = new CarRentalContext())
            {
                var updatedContext = carRentalContext.Entry(car);
                updatedContext.State = EntityState.Modified;
                carRentalContext.SaveChanges();
            }
        }
    }
}
