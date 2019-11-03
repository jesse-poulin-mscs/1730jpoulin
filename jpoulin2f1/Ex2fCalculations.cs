using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jpoulin2f1
{
    public class Ex2fCalculations
    {
        public static string Calc01(string input)
        {
            // #1: if
            decimal subtotal = 0.0m;
            decimal discountpercent = 0.0m;
            subtotal = Decimal.Parse(input);
            if (subtotal >= 100)
                discountpercent = 0.2m;
            return discountpercent.ToString("n2");
        }

        public static string Calc02(string input)
        {
            // #2: if {block}
            decimal subtotal = 0.0m;
            decimal discountpercent = 0.0m;
            subtotal = Decimal.Parse(input);
            string status = "Standard rate: ";
            if (subtotal >= 100m)
            {
                discountpercent = 0.2m;
                status = "Bulk rate: " + discountpercent.ToString("n2");
            }
            return status;
        }

        public static string Calc03(string input)
        {
            // #3: if else
            decimal subtotal = 0.0m;
            decimal discountpercent = 0.0m;
            discountpercent = 0.0m;
            subtotal = Decimal.Parse(input);
            if (subtotal >= 100m)
                discountpercent = 0.2m;
            else
                discountpercent = 0.1m;
            return discountpercent.ToString("n2");
        }

        public static string Calc04(string input)
        {
            // #4 if else if
            decimal subtotal = 0.0m;
            decimal discountpercent = 0.0m;
            discountpercent = 0.0m;
            subtotal = Decimal.Parse(input);
            if (subtotal >= 100m && subtotal < 200m)
                discountpercent = 0.2m;
            else if (subtotal >= 200m && subtotal < 300m)
                discountpercent = 0.3m;
            else if (subtotal >= 300m)
                discountpercent = 0.4m;
            else
                discountpercent = 0.1m;
            return discountpercent.ToString("n2");
        }

        public static string Calc05(string input)
        {
            // #5 Better range test
            decimal subtotal = 0.0m;
            decimal discountpercent = 0.0m;
            subtotal = Decimal.Parse(input);
            if (subtotal >= 300m)
                discountpercent = 0.4m;
            else if (subtotal >= 200m)
                discountpercent = 0.3m;
            else if (subtotal >= 100m)
                discountpercent = 0.2m;
            else
                discountpercent = 0.1m;
            return discountpercent.ToString("n2");
        }

        public static string Calc06(string inputA, string inputB)
        {
            // #6 Nested if
            decimal subtotal = 0.0m;
            decimal discountpercent = 0.0m;
            subtotal = Decimal.Parse(inputA);
            string customertype = inputB;
            if (customertype == "R")
            {
                if (subtotal >= 100m)
                    discountpercent = 0.2m;
                else
                    discountpercent = 0.1m;
            }
            else               // if customertype isn't "R"
                discountpercent = 0.4m;
            return discountpercent.ToString("n2");
        }

        public static string Calc07(string input)
        {
            // #7 Validate input: non-empty string
            decimal ethereum = 0.0m;
            if (input != "")
            {
                decimal dollars = Decimal.Parse(input);
                ethereum = 200m * dollars;
                return ethereum.ToString("n2");
            }
            return "Invalid input";
        }

        public static string Calc08(string inputA, string inputB)
        {
            // #8 Validate input, calculate quantity * price, shipping
            if (inputA != "" && inputB != "")
            {
                decimal price = Decimal.Parse(inputA);
                decimal quantity = Decimal.Parse(inputB);
                decimal total = price * quantity;
                decimal shipping = 5m;
                if (total >= 50)
                    return total.ToString("n2");
                else
                    return (total + shipping).ToString("n2");
            }
            return "Invalid input";
        }

        public static string Calc09(string inputA, string inputB)
        {
            // #9 Validate input, calculate difference * rate
            if (inputA != "" && inputB != "")
            {
                decimal firstread = Convert.ToDecimal(inputA);
                decimal secondread = Convert.ToDecimal(inputB);
                if (firstread <= secondread)
                {
                    return (0.1m * (secondread - firstread)).ToString("n2");
                }
            }
                return "Invalid input";
        }

        public static string Calc10(string inputA, string inputB)
        {
            // #10 Validate input, divide large num by small
            //     Both numbers must be > 0
            if (inputA != "" && inputB != "")
            {
                decimal firstnumber = Convert.ToDecimal(inputA);
                decimal secondnumber = Convert.ToDecimal(inputB);
                if (firstnumber > 0 && secondnumber > 0)
                {
                    if (firstnumber >= secondnumber)
                        return (firstnumber / secondnumber).ToString("n2");
                    else if (firstnumber < secondnumber)
                        return (secondnumber / firstnumber).ToString("n2");
                }
            }
                return "Invalid input";
        }
    }
}
