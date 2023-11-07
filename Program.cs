using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace para1337
{
    //Практика 2
    //Эта программа предоставляет список продуктов с ценами,
    //а затем запрашивает количество каждого продукта,
    //рассчитывает общую сумму и применяет скидку 5% в зависимости от времени покупки.
    class Program
    {
        static void Main()
        {
            // Создаел список продуктов с ценами
            var products = new Dictionary<string, double>()
        {
            { "Вода", 180.00 },
            { "Хлеб", 120.00 },
            { "Печеньки офигенные", 777.77 },
            { "Сок", 500.05 },
            { "Банан", 666.66 },
            { "Яблоко", 111.11 },
            { "Картошка", 200.00 },
            { "Лук", 100.00 },
            { "Арбуз", 150.50 },
            { "Молоко", 512.87 },
            { "Мохито", 450.00 }
        };

            DateTime currentTime = DateTime.Now;
            Console.WriteLine("Добро пожаловать в продуктовый супермаркет!");
            Console.WriteLine("Список доступных продуктов:");

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key}: {product.Value:F2}KZT");
            }

            double total = 0.0;

            if (currentTime.TimeOfDay >= TimeSpan.FromHours(8) && currentTime.TimeOfDay <= TimeSpan.FromHours(12))
            {
                Console.WriteLine("Скидка 5% применена!");
                foreach (var product in products)
                {
                    Console.Write($"Сколько {product.Key} вы хотите купить? ");
                    if (double.TryParse(Console.ReadLine(), out double quantity))
                    {
                        total += quantity * product.Value;
                    }
                }

                total *= 0.95;
            }
            else
            {
                foreach (var product in products)
                {
                    Console.Write($"Сколько {product.Key} вы хотите купить? ");
                    if (double.TryParse(Console.ReadLine(), out double quantity))
                    {
                        total += quantity * product.Value;
                    }
                }
            }
            Console.WriteLine($"Общая сумма: {total:F2}KZT");
        }
    }
}