using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUIU //ConsoleUI olması gerektiğini biliyorum ama bir yanlışlık yaptığım için öyle yazamadım :)
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            Console.WriteLine("----CAR LIST----");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("CarId:" + car.CarId + " BrandId:" + car.BrandId + " ColorId:" + car.ColorId+ " DailyPrice:" + car.DailyPrice + " Description:" +car.Description + " ModelYear:" +car.ModelYear);
            }
            Console.WriteLine("\n\n");

            Console.WriteLine("----GetById:1----");
            foreach (var car in carManager.GetById(1))
            {
                Console.WriteLine("CarId:" + car.CarId + " BrandId:" + car.BrandId + " ColorId:" + car.ColorId + " DailyPrice:" + car.DailyPrice + " Description:" + car.Description + " ModelYear:" + car.ModelYear);
            }
            Console.WriteLine("\n\n");

            Console.WriteLine("----GetById:2----");
            foreach (var car in carManager.GetById(2))
            {
                Console.WriteLine("CarId:" + car.CarId + " BrandId:" + car.BrandId + " ColorId:" + car.ColorId + " DailyPrice:" + car.DailyPrice + " Description:" + car.Description + " ModelYear:" + car.ModelYear);
            }
            Console.WriteLine("\n\n");

            Console.WriteLine("----GetById:3----");
            foreach (var car in carManager.GetById(3))
            {
                Console.WriteLine("CarId:" + car.CarId + " BrandId:" + car.BrandId + " ColorId:" + car.ColorId + " DailyPrice:" + car.DailyPrice + " Description:" + car.Description + " ModelYear:" + car.ModelYear);
            }
            Console.WriteLine("\n\n");

            Console.WriteLine("----GetById:4----");
            foreach (var car in carManager.GetById(4))
            {
                Console.WriteLine("CarId:" + car.CarId + " BrandId:" + car.BrandId + " ColorId:" + car.ColorId + " DailyPrice:" + car.DailyPrice + " Description:" + car.Description + " ModelYear:" + car.ModelYear);
            }
            Console.WriteLine("\n\n");

            Console.WriteLine("----GetById:5----");
            foreach (var car in carManager.GetById(5))
            {
                Console.WriteLine("CarId:" + car.CarId + " BrandId:" + car.BrandId + " ColorId:" + car.ColorId + " DailyPrice:" + car.DailyPrice + " Description:" + car.Description + " ModelYear:" + car.ModelYear);
            }
            Console.WriteLine("\n\n");

            Console.WriteLine("----GetByBrandId:1----");
            foreach (var car in carManager.GetByBrandId(1))
            {
                Console.WriteLine("CarId:" + car.CarId + " BrandId:" + car.BrandId + " ColorId:" + car.ColorId + " DailyPrice:" + car.DailyPrice + " Description:" + car.Description + " ModelYear:" + car.ModelYear);
            }
            Console.WriteLine("\n\n");

            Console.WriteLine("----GetByBrandId:2----");
            foreach (var car in carManager.GetByBrandId(2))
            {
                Console.WriteLine("CarId:" + car.CarId + " BrandId:" + car.BrandId + " ColorId:" + car.ColorId + " DailyPrice:" + car.DailyPrice + " Description:" + car.Description + " ModelYear:" + car.ModelYear);
            }
            Console.WriteLine("\n\n");

            Console.WriteLine("----GetByBrandId:3----");
            foreach (var car in carManager.GetByBrandId(3))
            {
                Console.WriteLine("CarId:" + car.CarId + " BrandId:" + car.BrandId + " ColorId:" + car.ColorId + " DailyPrice:" + car.DailyPrice + " Description:" + car.Description + " ModelYear:" + car.ModelYear);
            }
            Console.WriteLine("\n\n");

            Console.WriteLine("----GetByColorId:1----");
            foreach (var car in carManager.GetByColorId(1))
            {
                Console.WriteLine("CarId:" + car.CarId + " BrandId:" + car.BrandId + " ColorId:" + car.ColorId + " DailyPrice:" + car.DailyPrice + " Description:" + car.Description + " ModelYear:" + car.ModelYear);
            }
            Console.WriteLine("\n\n");

            Console.WriteLine("----GetByColorId:2----");
            foreach (var car in carManager.GetByColorId(2))
            {
                Console.WriteLine("CarId:" + car.CarId + " BrandId:" + car.BrandId + " ColorId:" + car.ColorId + " DailyPrice:" + car.DailyPrice + " Description:" + car.Description + " ModelYear:" + car.ModelYear);
            }
            Console.WriteLine("\n\n");

            Console.WriteLine("----GetByColorId:3----");
            foreach (var car in carManager.GetByColorId(3))
            {
                Console.WriteLine("CarId:" + car.CarId + " BrandId:" + car.BrandId + " ColorId:" + car.ColorId + " DailyPrice:" + car.DailyPrice + " Description:" + car.Description + " ModelYear:" + car.ModelYear);
            }
            Console.WriteLine("\n\n");
        }
    }
}
