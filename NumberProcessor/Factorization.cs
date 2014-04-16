using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic;

namespace NumberProcessor
{
    public class Factorization
    {
        List<int> factorsList = new List<int>();    //it is like a variable-length array
        
        public List<int> findFactors(int number)
        {
            int result;
            for (int i = 1; i <= number; i++)
            {
                result = number % i;
                if (result == 0)
                    factorsList.Add(i);
            }

            return factorsList;
        }

        public Int64 getSum(List<int> factorsList)
        {
            Int64 sum = 0;
            foreach (int element in factorsList)
            {
                sum = sum + (Int64)element;
            }

            return sum;
        }

        public decimal getAverage(List<int> factorsList)
        {
            decimal sum = 0,average = 0;
            foreach (int element in factorsList)
            {
                sum = sum + (decimal)element;
            }

            average = sum / factorsList.Count;

            return average;
        }

        public bool isPerfectNumber(List<int> factorsList, int number)
        {
            Int64 sum = 0;
            Int64 finalSum = 0;
            foreach (int element in factorsList)
            {
                sum = sum + (Int64)element;
            }

            finalSum = sum - number;

            if (finalSum == number)
                return true;
            else
                return false;
        }
    }
}
