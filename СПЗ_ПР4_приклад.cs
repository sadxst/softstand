using System;
using System.Text;
using System.Data;
using System.Runtime.InteropServices;
class Town
{
    public string Name;
    public string Country;
    public string Region;
    public int Population;
    public double YearIncome;
    public double Square;
    public bool HasPort;
    public bool HasAirport;
    public double GetYearIncomePerInhabitant()
    {
        return YearIncome / Population;
    }
}
class СП3_ПР4_приклад
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Потрібно ввести назву міста: ");
        string sName = Console.ReadLine();
        Console.Write("Потрібно ввести назву країни: ");
        string sCountry = Console.ReadLine();
        Console.Write("Потрібно ввести назву регіону: ");
        string sRegion = Console.ReadLine();
        Console.Write("Потрібно ввести кількість населення: ");
        string sPopulation = Console.ReadLine();
        Console.Write("Потрібно ввести річний дохід: ");
        string sYearIncome = Console.ReadLine();
        Console.Write("Потрібно ввести площу міста (в квадратних км): ");
        string sSquare = Console.ReadLine();
        Console.Write("Чи є у мiстi порт? (y - так, n - нi): ");
        ConsoleKeyInfo keyHasPort = Console.ReadKey();
        Console.WriteLine();
        Console.Write("Чи є у мiстi аеропорт? (y - так, n - нi): ");
        ConsoleKeyInfo keyHasAirport = Console.ReadKey();
        Console.WriteLine();
        Town OurTown = new Town();
        OurTown.Name = sName;
        OurTown.Country = sCountry;
        OurTown.Region = sRegion;
        OurTown.Population = int.Parse(sPopulation);
        OurTown.YearIncome = double.Parse(sYearIncome);
        OurTown.Square = double.Parse(sSquare);
        OurTown.HasPort = keyHasPort.Key == ConsoleKey.Y;
        OurTown.HasAirport = keyHasAirport.Key == ConsoleKey.Y;
        double YearIncomePerInhabitant = OurTown.GetYearIncomePerInhabitant();
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine();
        Console.WriteLine("Данi про об'єкт: ");
        Console.WriteLine();
        Console.WriteLine("Назва: " +OurTown.Name);
        Console.WriteLine("Країна: " +OurTown.Country);
        Console.WriteLine("Регіон: " +OurTown.Region);
        Console.WriteLine("Кількість населення: " +OurTown.Population);
        Console.WriteLine("Рiчний дохiд: " +OurTown.YearIncome.ToString("0.00"));
        Console.WriteLine("Площа: " +OurTown.Square.ToString("0.000"));
        Console.WriteLine(OurTown.HasPort ? "У мiстi є порт." : "У мiстi нема порту.");
        Console.WriteLine(OurTown.HasAirport ? "У мiстi є аеропорт." : "У мiстi нема аеропорту.");
        Console.WriteLine();
        Console.WriteLine("Середнiй рiчний дохiд на одного громадянина: "  + YearIncomePerInhabitant.ToString("0.00"));
    }
}