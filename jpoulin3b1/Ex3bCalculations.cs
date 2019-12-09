using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jpoulin3b1
{
    public class Ex3bCalculations
    {
        public static decimal GetDiscountPercent(decimal subtotal)
        {
            decimal discountPercent = 0m;
            if (subtotal >= 500m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;

            return discountPercent;
        }
        public static void GetDiscountPercent(decimal subtotal, out decimal discountPercent)
        {
            if (subtotal >= 500m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
        }
        public static decimal CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate, int months)
        {
            decimal futureValue = 0m;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }
            return futureValue;
        }
        public static void CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate, int months, ref decimal futureValue)
        {
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }
        }
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) / 1.8;
            return celsius;
        }
        public static void CelsiusToFahrenheit(double celsius, out double fahrenheit)
        {
            fahrenheit = (celsius * 1.8) + 32;
        }
        public static decimal GrossPay(decimal hours, decimal payrate)
        {
            decimal grossPay = 0m;
            if (hours <= 40)
                grossPay = hours * payrate;
            else
                grossPay = (40 * payrate) + (hours - 40m) * payrate * 1.5m;

            return grossPay;
        }
        public static decimal TotalHours(string strNumbers)
        {
            decimal total = 0;
            int startIndex = 0;

            while(startIndex < strNumbers.LastIndexOf(' '))
            {
                int endIndex = strNumbers.IndexOf(' ', startIndex);
                string strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                Decimal number = Decimal.Parse(strNumber);
                total += number;
                startIndex = endIndex + 1;
            }

            return total;
        }
        public static decimal GrossPay(string strNumbers, decimal payrate)
        {
            decimal totalhours = Ex3bCalculations.TotalHours(strNumbers);
            decimal grossPay = Ex3bCalculations.GrossPay(totalhours, payrate);
            return grossPay;
        }
    }
}
