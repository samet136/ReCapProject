using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.DTOs;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {


            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarId + " " + car.BrandName
                    + " " + car.ColorName + " " + car.ModelYear + 
                    " " + car.DailyPrice + " " + car.Description);
            }



            //ColorManager colorManager = new ColorManager(new EfColorDal());
            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine("{0}---{1}",color.ColorId,color.ColorName);
            //}

            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine(brand.BrandId+" "+brand.BrandName);
            //}


        }
    }
}
