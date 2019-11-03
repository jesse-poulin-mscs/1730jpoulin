using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jpoulin2e1
{
    public class LogicalOperations
    {
        // #01
        public static bool q01(decimal subtotal)
        {
            return subtotal >= 250 && subtotal < 500;
        }
        // #02
        public static bool q02(int timeInService)
        {
            return timeInService <= 4 || timeInService >= 12;
        }
        // #03
        public static bool q03(bool isValid, int years, int counter)
        {
            return isValid == true && counter++ < years;
        }
        // #04
        public static bool q04(bool isValid, int years, int counter)
        {
            return isValid == true & counter++ < years;
        }
        // #05
        public static bool q05(bool isValid, int years, int counter)
        {
            return isValid == true || counter++ < years;
        }
        // #06
        public static bool q06(bool isValid, int years, int counter)
        {
            return isValid == true | counter++ < years;
        }
        // #07
        public static bool q07(DateTime startDate, DateTime expirationDate, DateTime date, bool isValid)
        {
            return date > startDate && date < expirationDate || isValid == true;
        }
        // #08
        public static bool q08(decimal thisYTD, decimal lastYTD, string emptype, int startYear, int currentYear)
        {
            return (thisYTD > lastYTD) || emptype == "Part time" && startYear < currentYear;
        }
        // #09
        public static bool q09(int counter, int years)
        {
            return !(counter++ >= years);
        }
        // #10
        public static bool q10(int a, int b, int c, int d)
        {
            return a > b && b < c || c < d;
        }

        // #11
        public static bool q11(bool member, decimal price, float weight)
        {
            return member || price >= 25 || weight <= 1;
        }

        // #12
        public static bool q12(bool member, decimal price, float weight)
        {
            return member || price >= 25 && weight < 1;
        }

        // #13
        public static bool q13(string shipState, string itemType)
        {
            return shipState == "MN" && itemType == "Electronics";
        }
    }
}
