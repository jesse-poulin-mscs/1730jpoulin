using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jpoulin3a1
{
    public class Ex3aLoops
    {
        public static string Calc0(string strMonths, string strMonthlyPayment, string strMonthlyInterestRate)
        {
            double futureValue = 0.0;
            try
            {
                int months = Int32.Parse(strMonths);
                double monthlyPayment = Double.Parse(strMonthlyPayment);
                double monthlyInterestRate = Double.Parse(strMonthlyInterestRate);
                int i = 1;
                while (i <= months)
                {
                    futureValue = (futureValue + monthlyPayment) * (1 + monthlyInterestRate);
                    i++;
                }
            }
            catch 
            {
                return "Invalid input";
            }
            return futureValue.ToString("n2");
        }
        public static string Calc1(string strMonths, string strMonthlyPayment, string strMonthlyInterestRate)
        {
            double futureValue = 0.0;
            try
            {
                int months = Int32.Parse(strMonths);
                double monthlyPayment = Double.Parse(strMonthlyPayment);
                double monthlyInterestRate = Double.Parse(strMonthlyInterestRate);
                int i = 1;
                do
                {
                    futureValue = (futureValue + monthlyPayment) * (1 + monthlyInterestRate);
                    i++;
                }
                while (i <= months);
            }
            catch
            {
                return "Invalid input";
            }
            return futureValue.ToString("n2");
        }
        public static string Calc2(string strMonths, string strMonthlyPayment, string strMonthlyInterestRate)
        {
            double futureValue = 0.0;
            try
            {
                int months = Int32.Parse(strMonths);
                double monthlyPayment = Double.Parse(strMonthlyPayment);
                double monthlyInterestRate = Double.Parse(strMonthlyInterestRate);
                for (int i = 1; i <= months; i++)
                {
                    futureValue = (futureValue + monthlyPayment) * (1 + monthlyInterestRate);
                }
            }
            catch
            {
                return "Invalid input";
            }
            return futureValue.ToString("n2");
        }
        public static string Calc3(string strStart, string strEnd, string strIncrement)
        {
            string result = "";
            try
            {
                int start = Int32.Parse(strStart);
                int end = Int32.Parse(strEnd);
                int increment = Int32.Parse(strIncrement);
                if (increment <= 0) throw new Exception();
                while (start <= end)
                {
                    result += start.ToString() + " ";
                    start += increment;
                }
            }
            catch
            {
                result = "Invalid input";
            }
            
            return result;
        }

        public static string Calc4(string strStart, string strEnd, string strIncrement)
        {
            string result = "";
            try
            {
                int start = Int32.Parse(strStart);
                int end = Int32.Parse(strEnd);
                int increment = Int32.Parse(strIncrement);
                if (increment <= 0) throw new Exception();
                do
                {
                    result += start.ToString() + " ";
                    start += increment;
                }
                while (start <= end);
            }
            catch
            {
                result = "Invalid input";
            }

            return result;
        }

        public static string Calc5(string strStart, string strEnd, string strIncrement)
        {
            string result = "";
            try
            {
                
                int end = Int32.Parse(strEnd);
                int increment = Int32.Parse(strIncrement);
                if (increment <= 0) throw new Exception();
                for (int start = Int32.Parse(strStart); start <= end; start += increment)
                {
                    result += start.ToString() + " ";
                }
            }
            catch
            {
                result = "Invalid input";
            }

            return result;
        }

        public static string Calc6(string strNumbers, string strCount)
        {
            string result = "";
            int startIndex = 0;

            try
            {
                int sum = 0;
                int i = 0;
                int count = Int32.Parse(strCount);
                while (i < count) 
                {
                    int endIndex = strNumbers.IndexOf(' ', startIndex);
                    string strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                    int number = Int32.Parse(strNumber);
                    startIndex = endIndex + 1;
                    sum += number;
                    i++;
                }
                result = sum.ToString();
            }
            catch
            {
                return result = "Invalid input";
            }
            return result;
        }

        public static string Calc7(string strNumbers, string strCount)
        {
            string result = "";
            int startIndex = 0;

            try
            {
                int sum = 0;
                int i = 0;
                int count = Int32.Parse(strCount);
                do
                {
                    int endIndex = strNumbers.IndexOf(' ', startIndex);
                    string strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                    int number = Int32.Parse(strNumber);
                    startIndex = endIndex + 1;
                    sum += number;
                    i++;
                }
                while (i < count);
                result = sum.ToString();
            }
            catch
            {
                return result = "Invalid input";
            }
            return result;
        }

        public static string Calc8(string strNumbers, string strCount)
        {
            string result = "";
            int startIndex = 0;

            try
            {
                int sum = 0;
                int count = Int32.Parse(strCount);
                for (int i = 0; i < count; i++)
                {
                    int endIndex = strNumbers.IndexOf(' ', startIndex);
                    string strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                    int number = Int32.Parse(strNumber);
                    startIndex = endIndex + 1;
                    sum += number;
                }
                result = sum.ToString();
            }
            catch
            {
                return result = "Invalid input";
            }
            return result;
        }
    }
}
