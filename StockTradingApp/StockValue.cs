namespace StockTradingApp
{
    public class StockValue
    {
        public StockValue(int versionNumber, double amount, Curreny curreny)
        {
            VersionNumber = versionNumber;
            Amount = amount;
            Curreny = curreny;
        }

        public int VersionNumber { get; init; }
        public double Amount { get; init; }
        public Curreny Curreny { get; init; }
    }
}