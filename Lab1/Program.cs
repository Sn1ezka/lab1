using System;

namespace Lab1
{
    class Program
    {    
        static void Main(string[] args)
        {       
            var firstCar = new Car("Запорожец","Ukraine", DateTime.Now, 100, 7, 4){};
        
            var secondCar = new Car(firstCar){
                    Brand = "Жигуль", 
                    MaximumAcceleration = 120, 
                    FuelForOneHundredKm = 10, 
                    HoldingCapacity = 4
                };

            firstCar.WriteAllAttrToConsole();
            PrepareToWriteConsole();
            secondCar.WriteAllAttrToConsole();
            PrepareToWriteConsole();
            Console.WriteLine(Comparison.BestCarByTechParams(firstCar, secondCar));
            PrepareToWriteConsole();
        }

        static void PrepareToWriteConsole(){
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("------------------------");
            Console.ResetColor();
        }
    }
    
    /*
Написати програму, що включає реалізацію класів та функцій відповідно варіанту індивідуального завдання, 
а також реалізацію головної функції програми для демонстрація роботи з об’єктами класу. Кожен клас повинен мати:
    не менше трьох атрибутів;
    конструктор за замовченням;
    конструктор з параметрами;
    конструктор копіювання;
    деструктор;
    метод для виведення на екран значення всіх атрибутів класу.
У головній програмі використати всі види конструкторів. При визові конструкторів вивести на екран відповідні повідомлення.

Class - Автомобіль
Func - Функція порівняння
    */
}
