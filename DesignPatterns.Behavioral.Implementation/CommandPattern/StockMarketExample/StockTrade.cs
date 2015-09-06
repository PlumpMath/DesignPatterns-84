namespace DesignPatterns.Behavioral.Implementation.CommandPattern.StockMarketExample {

    using System;

    public class StockTrade : IStockTrade {

        public StockTrade(string symbol, int startPrice) {
            this.Symbol = symbol;
            this.Price = startPrice;
        }

        public string Symbol { get; set; }
        public int Price { get; set; }

        public void Buy() {
            this.Price++;
            Console.WriteLine("Bought {0} at ${1}/stock", this.Symbol.ToUpper(), this.Price);
        }

        public void Sell() {
            this.Price++;
            Console.WriteLine("Sold {0} at ${1}/stock", this.Symbol.ToUpper(), this.Price);
        }
    }
}
