public class ForecastTest {

    public static void main(String[] args) {

        double currentValue = 10000;   // Initial investment
        double growthRate = 0.10;      // 10% annual growth
        int years = 5;

        double future = FinancialForecast.futureValue(currentValue, growthRate, years);

        System.out.printf("Current Value : %.2f%n", currentValue);
        System.out.println("Growth Rate  : " + (growthRate * 100) + "%");
        System.out.println("Years        : " + years);
        System.out.printf("Future Value : %.2f%n", future);

    }
}