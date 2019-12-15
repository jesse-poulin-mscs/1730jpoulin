using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jpoulin3c1
{
    public class Ex3cCalculations
    {
        public static string Calc0(int index)
        {
            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            if (index >= 1 && index <= 7)
                return days[index-1];
            else
                return "Invalid index";
        }

        public static string Calc1(string search)
        {
            string[] days = { "SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY" };
            string[] hours = { "Closed", "10am - 6pm", "10am - 6pm", "10am - 6pm", "10am - 9pm", "10am - 6pm", "8am - 4pm" };
            try
            {
                int index = Array.IndexOf(days, search.ToUpper().Trim(' '));
                return hours[index];
            }
            catch
            {
                return "Invalid input";
            }
        }

        public static int Calc2(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
                sum += number;
            return sum;
        }
        public static double Calc3(double[] numbers, int count)
        {
            double sum = 0.0;
            if (count <= numbers.GetLength(0) && count >= 1)
            {
                for (int i = 0; i < count; i++)
                    sum += numbers[i];
                return sum;
            }
            else
                return 0.0;
        }
        public static double Calc5(double[] numbers)
        {
            double sum = 0.0;
            if (numbers.Length > 0)
            {
                foreach (double number in numbers)
                    sum += number;
                return sum / numbers.Length;
            }
            else
                return -1.0;
        }

        public static double[] Calc6(double[] numbers)
        {
            int length = numbers.GetLength(0);
            List<double> aboveAvgList = new List<double>();
            if (length > 0)
            {
                double avg = Calc5(numbers);
                foreach (double number in numbers)
                {
                    if (number >= avg)
                        aboveAvgList.Add(number);
                }
            }

            return aboveAvgList.ToArray();
        }
    }
}
