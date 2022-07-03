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
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                 new Car {CarId=1,BrandId=1,ColorId=1,ModelYear=2020,DailyPrice=1200,Description="Sedan" },
                 new Car {CarId=2,BrandId=1,ColorId=2,ModelYear=2021,DailyPrice=1400,Description="Hatchback" },
                 new Car {CarId=3,BrandId=2,ColorId=3,ModelYear=2022,DailyPrice=1500,Description="Cabrio" },
                 new Car {CarId=4,BrandId=3,ColorId=3,ModelYear=2019,DailyPrice=1000,Description="Pick up" },
                 new Car {CarId=5,BrandId=1,ColorId=2,ModelYear=2021,DailyPrice=1300,Description="SUV" },
                 new Car {CarId=6,BrandId=2,ColorId=3,ModelYear=2020,DailyPrice=1100,Description="Sedan" },
                 new Car {CarId=7,BrandId=2,ColorId=2,ModelYear=2018,DailyPrice=800,Description="Hatchback" }
            };

        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {

            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
