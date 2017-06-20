using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penalty_Calculation_Application
{
    
    public class Contributions
    {

        public int Year { get; set; }
        public int Month { get; set; }
        public double Amount { get; set; }
        public double Surcharge { get; set; }
        public double Additional { get; set; }
        public double TotalDebt { get; set; }
        public List<Contributions> completeContributionList = new List<Contributions>(); 

        public Contributions()
        {
            Year = 1990;
            Month = 1;
            Amount = 0.00;
            Surcharge = 0.00;
            Additional = 0.00;
            TotalDebt = 0.00;
        }

        public Contributions(int a, int b, double c, double d, double e, double f)
        {
            Year = a;
            Month = b;
            Amount = c;
            Surcharge = d;
            Additional = e;
            TotalDebt = f;
        }

        public void Add(Contributions cont)
        {
            completeContributionList.Add(cont);
        }

        /*
        public int GetYear()
        {
            return Year;
        }
        public int GetMonth()
        {
            return Month;
        }
        public double GetAmount()
        {
            return Amount;
        }
        public double GetSurcharge()
        {
            return Surcharge;
        }
        public double AdditionalSurcharge()
        {
            return AdditionalSurcharge;
        }
        public double GetTotalDebt()
        {
            return TotalDebt;
        }
        */

        public List<Contributions> GetContributionList()
        {
            return completeContributionList;
        }

        public void OutputContribution()
        {
            foreach (Contributions c in completeContributionList)
            {
                System.Diagnostics.Debug.WriteLine(c.Details());
            }
        }

        public void ClearList()
        {
            completeContributionList.Clear();
        }

        public string Details()
        {
            return Year + @" " + Month + @" " + Math.Round(Amount, 2, MidpointRounding.AwayFromZero) + @" " + Math.Round(Surcharge, 2, MidpointRounding.AwayFromZero) + @" " + Math.Round(Additional, 2, MidpointRounding.AwayFromZero) + @" " +
                   Math.Round(TotalDebt, 2, MidpointRounding.AwayFromZero);
        }
    }
    
}
