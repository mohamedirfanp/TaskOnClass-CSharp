using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOnCSharp._30_03_2023
{

    public class NormalCalculator
    {
        public virtual int Addition(int num1, int num2, int num3 = 0)
        {
            return num1 + num2 + num3;
        }

        public virtual int Subtraction(int num1, int num2, int num3 = 0)
        {
            return num1 - num2 - num3;

        }
    }

    public class OppositeCalculator : NormalCalculator
    {
        public override int Addition(int num1, int num2, int num3 = 0)
        {
            return num1 - num2 - num3;
        }
        public virtual int Subtraction(int num1, int num2, int num3 = 0)
        {
            return num1 + num2 + num3;
        }

    }
    internal class OppositeCalculators
	{
		public void Calculate()
		{
            NormalCalculator normalCalculator = new NormalCalculator();
            Console.WriteLine(normalCalculator.Addition(1, 2, 3));
            Console.WriteLine(normalCalculator.Subtraction(1, 2, 3));
            OppositeCalculator oppositeCalculator = new OppositeCalculator();
            Console.WriteLine(oppositeCalculator.Addition(30, 20, 1));
            Console.WriteLine(oppositeCalculator.Subtraction(10, 20, 30));
            
		}

		

	}
}
