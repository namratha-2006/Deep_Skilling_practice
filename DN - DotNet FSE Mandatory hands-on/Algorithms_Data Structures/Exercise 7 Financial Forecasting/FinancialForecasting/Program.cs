using System;

namespace FinancialForecasting
{
    class Program
    {
        static void Main(string[] args)
        {
            double principal = 10000;
            double rate = 0.10;
            int years = 5;

            double future = Forecast.FutureValue(principal, rate, years);

            Console.WriteLine("Future Value = " + future);

            Console.ReadKey();
        }
    }
}