namespace DesignPatterns.Behavioral.Implementation.CommandPattern.StockMarketExample {
    public class Client {
        public static void Main(){
            IStockTrade receiver = new StockTrade("MSFT", 1200);
            OrderCommand buyCommand = new BuyOrderCommand(receiver);
            OrderCommand sellCommand = new SellOrderCommand(receiver);
            Agent agent = new Agent();

            agent.PlaceOrder(buyCommand);
            agent.PlaceOrder(buyCommand);
            agent.PlaceOrder(buyCommand);

            agent.ExecuteOrder();

            agent.Revert(3);
        }
    }
}
