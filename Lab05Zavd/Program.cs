using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Lab05LibZavd;

namespace Lab05Zavd
{
    public class TelephoneApp
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Write("Введіть кількість телефонів: ");
            int count = int.Parse(Console.ReadLine());
            Telephone[] phones = new Telephone[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\nТелефон #{i + 1}");
                Console.Write("Назва (модель): ");
                string model = Console.ReadLine();
                Console.Write("Колір: ");
                string color = Console.ReadLine();
                Console.Write("Операційна система: ");
                string os = Console.ReadLine();
                Console.Write("Оперативна пам'ять (ГБ): ");
                int ram = int.Parse(Console.ReadLine());
                Console.Write("Кількість ядер: ");
                int cores = int.Parse(Console.ReadLine());
                Console.Write("Внутрішня пам'ять (ГБ): ");
                int memory = int.Parse(Console.ReadLine());
                Console.Write("Ємність батареї (мАг): ");
                int battery = int.Parse(Console.ReadLine());
                Console.Write("Підтримує NFC? (y/n): ");
                bool hasNfc = Console.ReadKey().Key == ConsoleKey.Y;
                Console.WriteLine();
                Console.Write("Підтримує швидке заряджання? (y/n): ");
                bool hasSpeedCharge = Console.ReadKey().Key == ConsoleKey.Y;
                Console.WriteLine();
                phones[i] = new Telephone
                {
                    Model = model,
                    Color = color,
                    OperatSystem = os,
                    Ram = ram,
                    Cores = cores,
                    Memory = memory,
                    Battery = battery,
                    HasNfc = hasNfc,
                    HasSpeedCharge = hasSpeedCharge
                };
            }
            Console.WriteLine("\n=== Список усіх телефонів ===\n");
            for (int i = 0; i < count; i++)
            {
                var phone = phones[i];
                Console.WriteLine($"Телефон #{i + 1}");
                Console.WriteLine($"Модель: {phone.Model}");
                Console.WriteLine($"Колір: {phone.Color}");
                Console.WriteLine($"ОС: {phone.OperatSystem}");
                Console.WriteLine($"Оперативна пам'ять: {phone.Ram} ГБ");
                Console.WriteLine($"Кількість ядер: {phone.Cores}");
                Console.WriteLine($"Внутрішня пам'ять: {phone.Memory} ГБ");
                Console.WriteLine($"Батарея: {phone.Battery} мАг");
                Console.WriteLine(phone.HasNfc ? "Підтримує NFC" : "Не підтримує NFC");
                Console.WriteLine(phone.HasSpeedCharge ? "Підтримує швидке заряджання" : "Не підтримує швидке заряджання");
                Console.WriteLine();
            }
            Console.WriteLine("Натисніть будь-яку клавішу для завершення...");
            Console.ReadKey();
        }
    }
}