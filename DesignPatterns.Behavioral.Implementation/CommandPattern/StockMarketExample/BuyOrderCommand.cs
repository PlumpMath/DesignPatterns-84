namespace DesignPatterns.Behavioral.Implementation.CommandPattern.StockMarketExample {

    public class BuyOrderCommand : OrderCommand {
        public BuyOrderCommand(IStockTrade receiver)
            : base(receiver) {

        }
        public override void Execute() {
            receiver.Buy();
        }

        public override void Undo() {
            receiver.Sell();
        }
    }
}
