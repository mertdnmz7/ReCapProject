using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public void Add(Car car)
        {
            if (car.DailyPrice > 0 && car.Description.Length >= 2)
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("The car name must be a minimum of 2 characters and a daily price of more than 0");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        
        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(d => d.BrandId == brandId).ToList();
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(d => d.ColorId == colorId).ToList();
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}