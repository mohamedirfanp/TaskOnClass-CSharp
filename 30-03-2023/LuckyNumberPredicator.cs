using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOnCSharp._30_03_2023
{

    public abstract class NumberPredictor
    {
        public abstract int CalculateLuckyNumber(int date, int month, int year);
        public abstract int CalculateUnluckyNumber(int date, int month, int year);
    }


    public class FibonacciNumberPredictor : NumberPredictor
    {
        public override int CalculateLuckyNumber(int date, int month, int year)
        {
            int dob = date + month + year;

            int prevFib = 0, currFib = 1, nextFib = 1;
            while(nextFib <= dob)
            {
                prevFib = currFib;
                currFib = nextFib;
                nextFib = prevFib + currFib;
            }

            int luckyNumber = (dob - prevFib < nextFib - dob)? prevFib : nextFib;
            return luckyNumber;
            
        }
        public override int CalculateUnluckyNumber(int date, int month, int year)
        {
            throw new NotImplementedException();
        }

    }
    internal class LuckyNumberPredicator
    {
        private NumberPredictor predictor;
        

        // Constructor
        public LuckyNumberPredicator()
        {
            predictor = new FibonacciNumberPredictor();
        }

        public int GetLuckyNumber(int date,int month, int year)
        {
            return predictor.CalculateLuckyNumber(date,month,year);
        }
        public int GetUnluckyNumber(int date, int month, int year)
        {
            return predictor.CalculateUnluckyNumber(date, month,year);
        }

    }



}
