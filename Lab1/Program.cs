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
                    var car = new Car(1000,"Audi","Germany", DateTime.Now, 250, 8, 4){};
                    Operations.CheckNameOfBrand(car, "Audi");
                    break;
                case "2":
                    var car1 = new Car(1000,"Audi","Germany", DateTime.Now, 250, 8, 4){};
                    var car2 = new Car(car1){Mileage = 100000, Brand = "Suzuki", MadeInCoutry = "Japan"};
                    Operations.ComparsionByMileage(car1,car2);
                    break;
                case "3":
                    var carPrepareToAddMileage = new Car(1000,"Audi","Germany", DateTime.Now, 250, 8, 4){};
                    Operations.AddingMileage(carPrepareToAddMileage, 222);
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
            var firstCar = new Car(10000,"Запорожец","Ukraine", DateTime.Now, 100, 7, 4){};
        
            var secondCar = new Car(firstCar){
                    Mileage = 55000,
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
