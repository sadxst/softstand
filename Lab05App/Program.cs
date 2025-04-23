using System;
using System.Text;
using Lab05Lib;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введіть кількість міст: ");
            int cntTowns = int.Parse(Console.ReadLine());
            Town[] arrTowns = new Town[cntTowns];
            for (int i = 0; i < cntTowns; i++)
            {
                Console.WriteLine($"\nМісто #{i + 1}");
                Console.Write("Назва: ");
                string name = Console.ReadLine();
                Console.Write("Країна: ");
                string country = Console.ReadLine();
                Console.Write("Регіон: ");
                string region = Console.ReadLine();
                Console.Write("Населення: ");
                int population = int.Parse(Console.ReadLine());
                Console.Write("Річний дохід: ");
                double income = double.Parse(Console.ReadLine());
                Console.Write("Площа: ");
                double square = double.Parse(Console.ReadLine());
                Console.Write("Є порт? (true/false): ");
                bool hasPort = bool.Parse(Console.ReadLine());
                Console.Write("Є аеропорт? (true/false): ");
                bool hasAirport = bool.Parse(Console.ReadLine());

                arrTowns[i] = new Town
                {
                    Name = name,
                    Country = country,
                    Region = region,
                    Population = population,
                    YearIncome = income,
                    Square = square,
                    HasPort = hasPort,
                    HasAirport = hasAirport
                };
            }
            Console.WriteLine("\n===== Інформація про міста =====");
            for (int i = 0; i < cntTowns; i++)
            {
                Town t = arrTowns[i];
                Console.WriteLine($"\nМісто #{i + 1}:");
                Console.WriteLine($"Назва: {t.Name}");
                Console.WriteLine($"Країна: {t.Country}");
                Console.WriteLine($"Регіон: {t.Region}");
                Console.WriteLine($"Населення: {t.Population}");
                Console.WriteLine($"Річний дохід: {t.YearIncome}");
                Console.WriteLine($"Площа: {t.Square}");
                Console.WriteLine($"Порт: {(t.HasPort ? "так" : "ні")}");
                Console.WriteLine($"Аеропорт: {(t.HasAirport ? "так" : "ні")}");
                Console.WriteLine($"Дохід на особу: {t.YearIncomePerInhabitant:F2}");
            }
            Console.WriteLine("\nНатисніть будь-яку клавішу для завершення...");
            Console.ReadKey();
        }
    }
}
