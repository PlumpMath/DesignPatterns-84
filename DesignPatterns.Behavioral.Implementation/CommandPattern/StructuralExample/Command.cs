namespace DesignPatterns.Behavioral.Implementation.CommandPattern.StructuralExample {
    /// <summary>
    /// Declares an interface for executing an operation
    /// </summary>
    public abstract class Command {
        protected IReceiver receiver;

        public Command(IReceiver receiver) {
            this.receiver = receiver;
        }

        public abstract void Execute();
    }
}
