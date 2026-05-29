using System;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

namespace Task.Service
{
    public class Calculator
    {
        static public double CalculateTips(double total, double totalWithTips)
        {
            double result = totalWithTips - total;

            if (CanContinue(result)) { return result; }
            return 0.00;
        }

        static public double CalculateTotalWithTips(double total, int tipsPercent)
        {
            if (total == 0)
            {
                throw new ArgumentException("Argument cannot be equal zero");
            }

            double result = total + (total * tipsPercent / 100);
            return result;
        }

        static public bool CanContinue(double result)
        {
            if (result <= 0)
            {
                return false;
            }
            return true;
        }
    }
}
