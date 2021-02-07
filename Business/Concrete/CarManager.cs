using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }


        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public IEnumerable<Car> GetAllByBrandId()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByBrandId(string id)
        {
            return _carDal.GetAll(p=>p.BrandId==id);
        }

        public List<Car> GetAllByColorId(int id)
        {
            return _carDal.GetAll(p=>p.ColorId==id);
        }

        public List<Car> GetAllByBrandId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
