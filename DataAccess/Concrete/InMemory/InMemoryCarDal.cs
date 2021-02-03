﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=150000,ModelYear=2020,Description="Sedan" },
                new Car{Id=2,BrandId=2,ColorId=5,DailyPrice=50000,ModelYear=2000,Description="2.el" },
                new Car{Id=3,BrandId=3,ColorId=2,DailyPrice=250000,ModelYear=2020,Description="Hatchback" },
                new Car{Id=4,BrandId=4,ColorId=4,DailyPrice=350000,ModelYear=2019,Description="SUV" },
                new Car{Id=5,BrandId=5,ColorId=6,DailyPrice=450000,ModelYear=2021,Description="SuperCar" },
            };
        }
      

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete;
            carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars; 
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(p => p.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate;
            carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
