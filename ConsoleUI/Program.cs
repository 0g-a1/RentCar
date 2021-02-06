using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            Console.WriteLine("\t\t\tEXISTING ONES\n");
            carManager.GetAll();
            Console.WriteLine("\n-------------------------------------------------------------------\n");

            Brand brand01 = new Brand() { BrandId = 1, BrandName = "BirinciModel" };

            Color color01 = new Color() { ColorId = 1, ColorName = "Red" };

            //Car car1 = new Car() { BrandId = 1, ColorId = 1, ModelYear = 1987, DailyPrice = 150, Description = "Eski ama sağlam araba" };

            //carManager.Add(new Car { BrandId = 1, ColorId = 1, ModelYear = 2000, DailyPrice = 200, Description = "İyi gider çok yakar" });

            Console.WriteLine("\n**************\n");
            Console.WriteLine(carManager.GetAll());


//            INSERT INTO Brands(BrandName) VALUES('Birinci Model'),('İkinci Model'),('Üçüncü Model');
//            INSERT INTO Colors(ColorName) VALUES('Kırmızı'),('Beyaz'),('Siyah');
//            INSERT INTO Cars(BrandId, ColorId, ModelYear, DailyPrice, Description)
//VALUES
//('1', '1', '1993', '150', 'Eski ama sağlam'),
//('2', '2', '2000', '250', 'Milenyum arabası'),
//('3', '3', '2010', '350', 'Pahalılık tam başlamadan önce ne güzeldi');





        }
    }
}
