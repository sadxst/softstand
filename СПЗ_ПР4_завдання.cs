using System;
using System.Text;
using System.Data;
using System.Runtime.InteropServices;
class Phone
{
    public string Model;
    public string Color;
    public string OperatSystem;
    public int Ram;
    public int Cores;
    public int Memory;
    public int Battery;
    public bool HasNfc;
    public bool HasSpeedCharge;
}
class СП3_ПР4_завдання
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Потрібно ввести назву (модель) телефона: ");
        string sModel = Console.ReadLine();
        Console.Write("Потрібно ввести колір: ");
        string sColor = Console.ReadLine();
        Console.Write("Потрібно ввести назву операційної системи: ");
        string sOperatSystem = Console.ReadLine();
        Console.Write("Потрібно ввести кількість оперативної пам'яті: ");
        string sRam = Console.ReadLine();
        Console.Write("Потрібно ввести кількість ядер процесора: ");
        string sCores = Console.ReadLine();
        Console.Write("Потрібно ввести кількість внутрішньої пам'яті: ");
        string sMemory = Console.ReadLine();
        Console.Write("Потрібно ввести ємність аккумулятора (мАг): ");
        string sBattery = Console.ReadLine();
        Console.Write("Чи підтримує пристрій технологію NFC? (y - так, n - нi): ");
        ConsoleKeyInfo keyHasNfc = Console.ReadKey();
        Console.WriteLine();
        Console.Write("Чи підтримує пристрій технологію швидкого заряджання? (y - так, n - нi): ");
        ConsoleKeyInfo keyHasSpeedCharge = Console.ReadKey();
        Console.WriteLine();
        Phone OurPhone = new Phone();
        OurPhone.Model = sModel;
        OurPhone.Color = sColor;
        OurPhone.OperatSystem = sOperatSystem;
        OurPhone.Ram = int.Parse(sRam);
        OurPhone.Cores = int.Parse(sCores);
        OurPhone.Memory = int.Parse(sMemory);
        OurPhone.Battery = int.Parse(sBattery);
        OurPhone.HasNfc = keyHasNfc.Key == ConsoleKey.Y;
        OurPhone.HasSpeedCharge = keyHasSpeedCharge.Key == ConsoleKey.Y;
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine();
        Console.WriteLine("Данi про телефон: ");
        Console.WriteLine();
        Console.WriteLine("Модель: " + OurPhone.Model);
        Console.WriteLine("Колір: " + OurPhone.Color);
        Console.WriteLine("Операційна система: " + OurPhone.OperatSystem);
        Console.WriteLine("Кількість оперативної пам'яті (Гб): " + OurPhone.Ram.ToString("0"));
        Console.WriteLine("Кількість ядер процесора: " + OurPhone.Cores.ToString("0"));
        Console.WriteLine("Кількість внутрішньої пам'яті (Гб): " + OurPhone.Memory.ToString("0"));
        Console.WriteLine("Ємність аккумулятора (мАг): " + OurPhone.Battery.ToString("0"));
        Console.WriteLine(OurPhone.HasNfc ? "Так, пристрій підтримує NFC." : "Ні, пристрій не підтримує NFC.");
        Console.WriteLine(OurPhone.HasSpeedCharge ? "Так, пристрій підтримує швидке заряджання." : "Ні, пристрій не підтримує швидке заряджання.");
        Console.WriteLine();
    }
}
