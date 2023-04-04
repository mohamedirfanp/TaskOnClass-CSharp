using TaskOnCSharp._27_03_2023;
using TaskOnCSharp._28_03_2023;
using TaskOnCSharp._30_03_2023;
using TaskOnCSharp._31_03_2023;
using TaskOnCSharp._04_04_2023;

namespace TaskOnCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 27-03-2023
            //SpiralMatrix sm = new SpiralMatrix();
            //sm.SpiralMatrixTraversal();

            //Buy_Sell prob2 = new();
            //prob2.FindMaxProfit();

            // 28-03-2023
            //RotateMatrix rotateMatrix = new RotateMatrix();
            //rotateMatrix.RotateGivenMatrix();

            // 30-03-2023
            // Opposite Calculator
            //OppositeCalculators oppositeCalculators = new OppositeCalculators();
            //oppositeCalculators.Calculate();


            //// LuckyNumber predicator
            //LuckyNumberPredicator luckyNumberPredicator = new LuckyNumberPredicator();
            //Console.WriteLine(luckyNumberPredicator.GetLuckyNumber(12,03,2001));
            //Console.WriteLine(luckyNumberPredicator.GetUnluckyNumber(12, 03, 2001));

            // 31-03-2023
            //ArrangementAsync arrangementAsync = new ArrangementAsync();
            //arrangementAsync.ArrangementAsyncMain();

            //CalculateOvertime calculateOvertime = new CalculateOvertime();
            //calculateOvertime.MainBlock();
            string[] hand = { "10h", "Jh", "Qh", "Ah", "Kh" };
            //string[] hand = { "10h", "10s", "9c", "9s", "Kd" };

            Pokers pokerHandRanking = new Pokers();
            pokerHandRanking.PokerHandRanking(hand);
        }
    }
}