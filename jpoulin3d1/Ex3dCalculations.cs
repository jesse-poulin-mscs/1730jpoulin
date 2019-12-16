using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jpoulin3d1
{
    public class Ex3dCalculations
    {
        public static string ArrayToString(int[] values)
        {
            // Create StringBuilder object: sbResult
            // loop
            //     convert current value to string, append to sbResult
            //     append ", " to sbResult
            // convert sbResult to string: result
            // remove last ", " from result
            // return result
            StringBuilder sbResult = new StringBuilder(200);
            string result;
            foreach (int value in values)
            {
                sbResult.Append(value);
                sbResult.Append(", ");
            }
            int index = sbResult.ToString().LastIndexOf(", ");
            result = sbResult.ToString();
            result = result.Remove(index, 2);
            return result;
        }

        public static int ValueCount(int[] values, int searchValue)
        {
            // create counter variable
            // loop
            //     increment counter if current value equals searchValue
            // return counter
            int count = 0;
            foreach (int value in values)
            {
                int currentValue = value;
                if (currentValue == searchValue)
                    count += 1;
            }
            return count;
        }

        public static int RangeCount(int[] values, int searchMin, int searchMax)
        {
            // create counter variable
            // loop
            //     increment counter if current value between min and max (inclusive)
            // return counter
            int count = 0;
            foreach (int value in values)
            {
                int currentValue = value;
                if (currentValue >= searchMin && currentValue <= searchMax)
                    count += 1;
            }
            return count;
        }
    }
}
