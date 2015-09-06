namespace DesignPatterns.Behavioral.Implementation.CommandPattern.StockMarketExample {
    public class SellOrderCommand : OrderCommand {
        public SellOrderCommand(IStockTrade receiver)
            : base(receiver) {

        }

        public override void Execute() {
            receiver.Sell();
        }

        public override void Undo() {
            receiver.Buy();
        }
    }
}
