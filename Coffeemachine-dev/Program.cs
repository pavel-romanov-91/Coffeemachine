
using System;
using System.Collections.Generic;

namespace coffeemachine
{
    class Program
    {
    static void Main(string[] args)
    {

        CoffeeMachine coffeeMachine = new CoffeeMachine();
        coffeeMachine.TurnOn();
        coffeeMachine.AddWater(500);
        coffeeMachine.AddMilk(300);
        coffeeMachine.AddCoffee(200);
        Console.WriteLine("Меню кофемашины");
        Console.WriteLine("1. Приготовить Эспрессо");
        Console.WriteLine("2. Приготовить Капучино");
        Console.WriteLine("3. Проверить уровень воды");
        Console.WriteLine("4. Проверить уровень молока");
        Console.WriteLine("5. Проверить уровень кофе");
        Console.WriteLine("6. Очистить кофемашину");
        Console.WriteLine("7. Вывести историю");
        Console.WriteLine("8. Выключить");
        Console.WriteLine("0. Возврат в меню");
        void PrintStart()
        {
        
        Console.WriteLine("Меню кофемашины");
        Console.WriteLine("1. Приготовить Эспрессо");
        Console.WriteLine("2. Приготовить Капучино");
        Console.WriteLine("3. Проверить уровень воды");
        Console.WriteLine("4. Проверить уровень молока");
        Console.WriteLine("5. Проверить уровень кофе");
        Console.WriteLine("6. Очистить кофемашину");
        Console.WriteLine("7. Вывести историю");
        Console.WriteLine("8. Выключить");
        Console.WriteLine("0. Возврат в меню");
        
        }

        void vbor()
        {
            Console.Clear();
            Console.WriteLine("Выберите размер кружки: ");
                Console.WriteLine("1. Маленькая: ");
                Console.WriteLine("2. Средняя: ");
                Console.WriteLine("3. Большая: ");
                Console.WriteLine("Ваш выбор");
                DrinkSize size1 = (DrinkSize)(int.Parse(Console.ReadLine())-1);
                Console.Write("Введдите количество кружек");
                int cups1 = int.Parse(Console.ReadLine());
                coffeeMachine.BrewEspresso(size1, cups1);
                
        }
        
        while(true)
        {
            Console.Write("Введите ваш выбор");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "0":
                PrintStart();
                break;
                case "1":
                vbor();
                 PrintStart();
                break;
                case "2":
                Console.Clear();
                Console.WriteLine("Выберите размер кружки: ");
                Console.WriteLine("1. Маленькая: ");
                Console.WriteLine("2. Средняя: ");
                Console.WriteLine("3. Большая: ");
                Console.WriteLine("Ваш выбор");
                DrinkSize size2 = (DrinkSize)(int.Parse(Console.ReadLine())-1);
                Console.Write("Введдите количество кружек");
                int cups2 = int.Parse(Console.ReadLine());
                coffeeMachine.BrewCappuccino(size2, cups2);
                PrintStart();
                break;
                case "3":
                Console.Clear();
                Console.WriteLine($"Уровень воды: {coffeeMachine.CheckWater()}мл");
                PrintStart();
                break;
                case "4":
                Console.Clear();
                Console.WriteLine($"Уровень молока: {coffeeMachine.CheckMilk()}мл");
                PrintStart();
                break;
                case "5":
                Console.Clear();

                Console.WriteLine($"Уровень кофе: {coffeeMachine.CheckCoffee()}г");
                PrintStart();
                break;
                case "6":
                Console.Clear();
                coffeeMachine.Clean();
                PrintStart();
                break;
                case "7":
                Console.Clear();
                coffeeMachine.Log();
                PrintStart();
                break;
                
                case "8":
                Console.Clear();
                coffeeMachine.TurnOff();
                PrintStart();
                return;

                default:
                Console.WriteLine("Неверный выбор. Пожалуста, введите число от 1 до 8.");
                PrintStart();
                break;
            }
        }
    }
    }
}



// Включение / выключение кофемашины
// Добавить воды
// Защита от перелива
// Добавить кофе
// Добавить молоко
// Проверить, сколько молока
// Проверить, сколько воды
// Проверить, есть ли кофе
// Проверить, не нужно ли ее очистить
// Очистка кофе машины
// Приготовить Эспрессо
// Приготовить Капучино
// Добавить функционал создания 3 порций любого напитка
// Добавить функционал выбора количества кружек напитка для изготовления
// Добавить функционал логирования работы кофемашины с возможностью вывода всех приготовленных напитков
// Добавить возможность добавления профилей с фиксированными напитками и последующим быстрым набором
// Добавить функционал вывода рецепта напитка по названию напитка

// Защита от перелива воды
// Лимит на зерна в машине
// Защита от перелива молока
// Предотвратить ненужную чистку
// При приготовлении кофе должны быть соблюдены:
// Проверка, на наличие всех ингредиентов
// Проверка на очистку
// Кофемашина должна быть включена
// Добавление и получение данных через getters, setters
// Реализовать статичные методы
// Реализовать статичные поля
// Использовать enum
// Залогированы должны быть только те операции, которые были выполнены
// Все исключения обрабатывать путем пробрасывание ошибки и обработки через конструкцию try / catch