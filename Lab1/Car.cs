using System;

namespace Lab1
{
    public class Car
    {
        public int Mileage { get; set; }
        public string Brand { get; set; }
        public string MadeInCoutry { get; set; }
        public DateTime ReleaseDate { get; set; }
        
        public int MaximumAcceleration { get; set; }
        
        public int FuelForOneHundredKm { get; set; }
        public int HoldingCapacity { get; set; }
    
        public string DateActual { get; set; }
    
        public Car()
        {
            Console.WriteLine("Call default constructor");
            DateActual = $"Дата показа данных:{DateTime.Today}";
        }

        public Car(int mileage, string brand, string madeInCoutry, DateTime releaseDate, int maximumAcceleration, int fuelForOneHundredKm, int holdingCapacity) : this()
        {
            Console.WriteLine("Call constructor with params");
            Mileage = mileage;
            Brand = brand;
            MadeInCoutry = madeInCoutry;
            ReleaseDate = releaseDate;
            MaximumAcceleration = maximumAcceleration;
            FuelForOneHundredKm = fuelForOneHundredKm;
            HoldingCapacity = holdingCapacity;
        }

        public Car(Car car)
        {
          Console.WriteLine("Call copy constructor");
          Mileage = car.Mileage;
          Brand = car.Brand;
          MadeInCoutry = car.MadeInCoutry;
          ReleaseDate = car.ReleaseDate;
          MaximumAcceleration= car.MaximumAcceleration; 
          FuelForOneHundredKm = car.FuelForOneHundredKm;
          HoldingCapacity = car.HoldingCapacity;
          DateActual = car.DateActual;
        }

        ~Car()
        {
            Console.WriteLine("Call destructor");
            Console.Beep();
            Console.WriteLine("Disposed");
        }    
        public void WriteAllAttrToConsole()
        {   
            Console.WriteLine("Call WriteAllAttrToConsole method");
            Console.WriteLine($"Автомобиль:{Brand} \nСтрана выпуска:{MadeInCoutry} \nДата выпуска:{ReleaseDate} \nМакс. скорость:{MaximumAcceleration} \nРасход на 100км:{FuelForOneHundredKm} \nВместимость:{HoldingCapacity}");
        }
    } 
}
