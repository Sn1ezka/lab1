using System;

namespace Lab1
{
    public class Car
    {
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

        public Car(string Brand, string MadeInCoutry, DateTime ReleaseDate, int MaximumAcceleration, int FuelForOneHundredKm, int HoldingCapacity)
        {
            Console.WriteLine("Call constructor with params");
            new Car(){Brand = Brand, MadeInCoutry = MadeInCoutry, ReleaseDate = ReleaseDate, MaximumAcceleration=MaximumAcceleration, FuelForOneHundredKm = FuelForOneHundredKm, HoldingCapacity = HoldingCapacity};
        }

        public Car(Car car)
        {
          Console.WriteLine("Call copy constructor");
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