﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carmanager = new CarManager(new EfCarDal());
            
            foreach (var car in carmanager.GetAll())
            {
                Console.WriteLine(car.Description + " " + car.DailyPrice);
            }
        }
    }
}
