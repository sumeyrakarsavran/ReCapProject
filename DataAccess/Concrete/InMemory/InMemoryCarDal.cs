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
        List<Color> _colors;
        List<Brand> _brands;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1, BrandId=1, ColorId=2, DailyPrice=70000, ModelYear="2010", Description="ABC"},
                new Car{CarId=2, BrandId=3, ColorId=3, DailyPrice=80000, ModelYear="2005", Description="XYZ"},
                new Car{CarId=3, BrandId=2, ColorId=2, DailyPrice=60000, ModelYear="2007", Description="YTR"},
                new Car{CarId=4, BrandId=1, ColorId=1, DailyPrice=66000, ModelYear="2009", Description="UIU"},
                new Car{CarId=5, BrandId=3, ColorId=2, DailyPrice=76000, ModelYear="2003", Description="OPP"},
            };

            _colors = new List<Color>
            {
                new Color{ColorId=1, ColorName="White"},
                new Color{ColorId=2, ColorName="Black"},
                new Color{ColorId=3, ColorName="Red"},
            };

            _brands = new List<Brand>
            {
                new Brand{BrandId=1, BrandName="Hyundai"},
                new Brand{BrandId=2, BrandName="Toyota"},
                new Brand{BrandId=3, BrandName="BMW"}
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

        public List<Car> GetByBrandId(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<Car> GetByColorId(int colorId)
        {
            return _cars.Where(c => c.ColorId == colorId).ToList();
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
