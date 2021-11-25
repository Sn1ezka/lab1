using System;

namespace Lab1
{
    class Program
    {    
        static void Main(string[] args)
        {       
           Console.WriteLine("App started");
           Console.WriteLine("Для відображення прикладу по лаб1 введіть: default");
           Console.WriteLine("(1) ==> Не дорівнює за назвами (!=) \n(2) ==> Більше за «пробігом» (>) \n(3) ==> Додавання «пробігу» (+)");
           string oper = Console.ReadLine();
           switch (oper)
           {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "default":
                    Console.WriteLine("lab1");
                    DefaultExampleWithTwoCars();
                    break;
                default:
                    Console.WriteLine("Nothing to show");
                    break;
           }
            
           
        }

        static void DefaultExampleWithTwoCars()
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

Lab2:
Не дорівнює за назвами (!=)
Більше за «пробігом» (>)
Додавання «пробігу» (+)

    */
}
