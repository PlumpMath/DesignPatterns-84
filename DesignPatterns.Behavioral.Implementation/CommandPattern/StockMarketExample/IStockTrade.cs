namespace DesignPatterns.Behavioral.Implementation.CommandPattern.StockMarketExample {
    public interface IStockTrade {

        string Symbol { get; set; }
        int Price { get; set; }

        void Buy();
        void Sell();
    }
}
