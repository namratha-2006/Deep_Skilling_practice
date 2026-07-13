namespace FinancialForecasting
{
    public class Forecast
    {
        public static double FutureValue(double amount, double rate, int years)
        {
            if (years == 0)
                return amount;

            return FutureValue(amount * (1 + rate), rate, years - 1);
        }
    }
}