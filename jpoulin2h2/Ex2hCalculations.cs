using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
namespace jpoulin2h2
{
    public class Ex2hCalculations
    {
        public static string DateCalc06(string strYear, string strMonth, string strDay)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                int year = Int32.Parse(strYear);
                int month = Int32.Parse(strMonth);
                int day = Int32.Parse(strDay);
                date = new DateTime(year, month, day);
                result = date.ToShortDateString();
            }
            catch { }

            
            return result;
        }
        public static string DateCalc07(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                date = DateTime.Parse(strDate);
                result = date.ToShortDateString();
            }
            catch { }


            return result;
        }
        public static string DateCalc08(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            DateTime.TryParse(strDate, out date);
            result = date.ToShortDateString();

            return result;
        }
        public static string DateCalc09(string strDateA, string strDateB)
        {
            string result = "Invalid input";
            DateTime dateA, dateB;
            try
            {
                dateA = DateTime.Parse(strDateA);
                dateB = DateTime.Parse(strDateB);
                result = (dateA - dateB).Days.ToString() + " days";
            }
            catch { }


            return result;
        }
        public static string DateCalc10(string strDateA, string strDateB)
        {
            string result = "Invalid input";
            DateTime dateA, dateB;
            try
            {
                dateA = DateTime.Parse(strDateA);
                dateB = DateTime.Parse(strDateB);

                if (dateA > dateB)
                {
                    result = (dateA - dateB).Days.ToString() + " days past due";
                }
                else
                    result = "On time";
            }
            catch { }
            return result;
        }
        public static string StringCalc01(string strString)
        {
            return strString.Replace("l", "cr");
        }
        public static string StringCalc02(string strString)
        {
            return strString.Replace("a", "rit");
        }
        public static string StringCalc03(string strString)
        {
            strString.Remove(0, 1);
            strString.Remove(6);
            return strString.Substring(2, 4).ToUpper();
        }
        public static string StringCalc04(string strString)
        {
            char pad = '*';
            return strString.PadLeft(10, pad);
        }
        public static string StringCalc05(string strString)
        {
            return strString.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
        }
        public static string StringCalc06(string strString)
        {
            strString = strString.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            if (strString.Length == 7)
            {
                return strString.Insert(3, ".");
            }
            else if (strString.Length == 10)
                return strString.Insert(3, ".").Insert(7, ".");
            else
                return strString = "Invalid input";
        }
        public static string StringCalc07(string strString)
        {
            strString = strString.ToLower();
            if (strString.Contains("pioneer"))
                return "Found";
            else
                return "Not found";
        }
        public static string StringCalc08(string strString)
        {
            if (strString.Contains(","))
            {
                int city = strString.IndexOf(",");
                return strString.Substring(city + 1);
            }
            else
                return "Invalid input";
        }
        public static string StringCalc09(string strString)
        {
            if (strString.Contains(" "))
            {
                int zip = strString.LastIndexOf(" ");
                return strString.Substring(zip + 1);
            }
            else
                return "Invalid input";
        }
        public static string StringCalc10(string strString1, string strString2, string strString3)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(strString1);
            sb.Append(", ");
            sb.Append(strString2);
            sb.Append(", ");
            sb.Append(strString3);
            return sb.ToString();
        } 
    }
}