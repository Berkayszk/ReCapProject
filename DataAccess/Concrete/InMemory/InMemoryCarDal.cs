using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
              new Car { Id=1, ColorId=2, BrandId="Honda", ModelYear=2021, DailyPrice=300.000, Description="SUV"},
              new Car { Id=2, ColorId=5, BrandId="Toyota", ModelYear=2019, DailyPrice=150.000, Description="Crossover"},
              new Car { Id=3, ColorId=3, BrandId="Mercedes-Benz", ModelYear=2021, DailyPrice=350.000, Description="Sedan"},
              new Car { Id=4, ColorId=1, BrandId="BMW", ModelYear=2021, DailyPrice=450.000, Description="Cabrio"}

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

     

        public List<Car> GetAllColorId(int colorId)

        {
            
           return _cars.Where(c=>c.ColorId==colorId).ToList();
        }

        public Car Get()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;

        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
    }
}
