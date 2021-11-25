using System;

namespace Lab1
{
    public static class Operations
    {   
/// <summary>
/// Порівнює бренд обєкта та переданої строки, та повертає ОК якщо не дорівнює
/// </summary>
/// <param name="car"></param>
/// <param name="NameCheck"></param>
/// <returns></returns>
        public static void CheckNameOfBrand(Car car, string NameCheck)
        {
            Console.WriteLine("Call CheckNameOfBrand");
            Console.WriteLine($"Сравниваем {car.Brand} и {NameCheck} ");
            Console.WriteLine($"Не равны ли названия(да/нет): {car.Brand != NameCheck}");
        }

        public static void ComparsionByMileage(Car firstCar, Car secondCar)
        {
            Console.WriteLine("Call ComparsionByMileage");
            Console.WriteLine($"Пробег первого:{firstCar.Mileage}\n Пробег второго:{secondCar.Mileage}");
            Console.WriteLine(firstCar.Mileage>secondCar.Mileage? $"Автомобиль {firstCar.Brand} лучше, чем {secondCar.Brand}" : $"Автомобиль {secondCar.Brand} лучше, чем {firstCar.Brand}");
        }
        
        public static void AddingMileage(Car firstCar, int mileage)
        {
            Console.WriteLine("Call ComparsionByMileage");
            Console.WriteLine($"Пробега до добавления:{firstCar.Mileage} \nДобавлено:{mileage} \nВсего пробега после добавления: {firstCar.Mileage+=mileage}"); 
        }
    } 
}
/*
Завдання
Написати програму, що включає реалізацію класу відповідно варіанту 
індивідуального завдання, а також реалізацію головної функції програми 
для демонстрація роботи з об’єктами класу.

Клас має включати:
не менше трьох атрибутів;
конструктор за замовченням;
конструктор з параметрами;
конструктор копіювання;
деструктор;
метод для виведення на екран значення всіх атрибутів класу;
перевантажені операції відповідно до варіанту.
У головній програмі створити меню для вибору операцій. При виконанні 
операцій на екрані повинні відображатися найменування операції (суть), 
операнди та результат.

Не дорівнює за назвами (!=)
Більше за «пробігом» (>)
Додавання «пробігу» (+)
*/
