using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            Notebook notebook1 = new Notebook()
            {
                Name = "Apple",
                BrandName = "Macintosh",
                Price = 3400

            };
            Notebook notebook2 = new Notebook()
            {
                Name = "HP",
                BrandName = "Spectre",
                Price = 2300

            };
            Notebook notebook3 = new Notebook()
            {
                Name = "Lenovo",
                BrandName = "Thinkpad",
                Price = 1200

            };
            Notebook notebook4 = new Notebook()
            {
                Name = "Asus",
                BrandName = "ROG Strix",
                Price = 5000

            };
            Notebook notebook5 = new Notebook()
            {
                Name = "Dell",
                BrandName = "Inspiron",
                Price = 1000

            };
            Notebook notebook6 = new Notebook()
            {
                Name = "Microsoft",
                BrandName = "Surface",
                Price = 6500

            };

            Notebook[] notebooks = new Notebook[] { notebook1, notebook2, notebook3, notebook4, notebook5, notebook6 };
            FilterPrice(notebooks);
            #endregion

            #region Task 3
            Car car1 = new Car()
            {
                Brand = "BMW",
                Model = "M5",
                CurrentFuel = 35,
                FuelForOneKilometer = 0.214,
                Milage = 30000
            };
            Drive(100, car1);


            #endregion


        }
        #region Task 2
        static void FilterPrice(Notebook[] ntb)
        {
            Console.WriteLine("Minimum deyeri daxil edin...");
            int minPrice = int.Parse(Console.ReadLine());
            Console.WriteLine("Maximum deyeri daxil edin...");
            int maxPrice = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < ntb.Length; i++)
            {
                if (ntb[i].Price > minPrice && ntb[i].Price < maxPrice)
                {
                    Console.WriteLine($"{ntb[i].Name} {ntb[i].BrandName}  Price: {ntb[i].Price}");
                    count++;
                }

            }
            if (count == 0)
            {
                Console.WriteLine("Istediyin qiymet araliqinda mehsul yoxdur....");
            }
        }
        #endregion

        static void Drive( double wantedRoad, Car car)
        {
            double availableRoad = car.CurrentFuel / car.FuelForOneKilometer;
            if (availableRoad >= wantedRoad)
            {
                    car.CurrentFuel = (availableRoad - wantedRoad) * car.FuelForOneKilometer;
                    car.Milage += wantedRoad;
            }
            else
            {
                Console.WriteLine("Benzin al bu yolu gede bilmezsen ");
            }
        }
    }
}
