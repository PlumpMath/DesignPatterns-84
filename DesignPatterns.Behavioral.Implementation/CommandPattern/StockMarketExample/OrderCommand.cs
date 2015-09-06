namespace DesignPatterns.Behavioral.Implementation.CommandPattern.StockMarketExample {
    public abstract class OrderCommand {
        protected IStockTrade receiver;
        public OrderCommand(IStockTrade receiver) {
            this.receiver = receiver;
        }
        public abstract void Execute();
        public abstract void Undo();
    }
}
