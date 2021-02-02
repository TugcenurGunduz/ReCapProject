using DataAccess.Abstract;
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
            _cars = new List<Car>
            {
                new Car{Id=1, BrandId=1, ColorId=1, DailyPrice=100000, Description="aaaa", ModelYear=2020},
                new Car{Id=2, BrandId=2, ColorId=2, DailyPrice=200000, Description="bbbb", ModelYear=2019},
                new Car{Id=3, BrandId=3, ColorId=3, DailyPrice=300000, Description="cccc", ModelYear=2018},
                new Car{Id=4, BrandId=4, ColorId=4, DailyPrice=400000, Description="dddd", ModelYear=2017},
                new Car{Id=5, BrandId=5, ColorId=5, DailyPrice=500000, Description="eeee", ModelYear=2016}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car productToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);

            _cars.Remove(productToDelete);
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
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
