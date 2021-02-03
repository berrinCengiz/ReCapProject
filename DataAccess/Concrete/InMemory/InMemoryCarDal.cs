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
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{ Id=1, BrandId=1,ColorId=1,ModelYear=2011, DailyPrice=250, Description="Syangyong Kyron 4*4" },
                new Car{ Id=2, BrandId=2,ColorId=2,ModelYear=2017, DailyPrice=150, Description="Fiat Linea" },
                new Car{ Id=3, BrandId=1,ColorId=2,ModelYear=2020, DailyPrice=300, Description="Syangyong Korando" }
            };
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c => c.Id== car.Id);
            _car.Remove(car);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int brandId)
        {
            return _car.Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
