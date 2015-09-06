namespace DesignPatterns.Behavioral.Implementation.CommandPattern.StockMarketExample {

    using System.Collections.Generic;

    // Invoker
    public class Agent {

        private Queue<OrderCommand> queueOrder;
        private Stack<OrderCommand> stackTrace;

        public Agent() {
            this.queueOrder = new Queue<OrderCommand>();
            this.stackTrace = new Stack<OrderCommand>();
        }

        public void PlaceOrder(OrderCommand order) {
            this.queueOrder.Enqueue(order);
        }

        public void ExecuteOrder() {
            while (this.queueOrder.Count > 0) {

                var command = this.queueOrder.Dequeue();

                this.stackTrace.Push(command);
                command.Execute();

            }
        }

        public void Revert() {
            if (this.stackTrace.Count > 0)
                this.stackTrace.Pop().Undo();
        }

        public void Revert(int step) {
            for (int i = 0; i < step && this.stackTrace.Count > 0; i++) {
                this.stackTrace.Pop().Undo();
            }
        }
    }
}
