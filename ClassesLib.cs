using System;
namespace Lab05Lib
{
    public class Town
    {
        public string Name; 
        public string Country; 
        public string Region; 
        public int Population; 
        public double YearIncome; 
        public double Square; 
        public bool HasPort;
        public bool HasAirport;
        public double YearIncomePerInhabitant
        {
            get
            {
                return GetYearIncomePerInhabitant();
            }
        }
        public double GetYearIncomePerInhabitant()
        {
            return YearIncome / Population;
        }
    }
}