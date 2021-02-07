using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
        }

        private static void CarTest()
        {
            CarManager carmanager = new CarManager(new EfCarDal());
            foreach (var car in carmanager.GetAll())
            {
                Console.WriteLine(car.BrandId);
            }
        }
    }
}
