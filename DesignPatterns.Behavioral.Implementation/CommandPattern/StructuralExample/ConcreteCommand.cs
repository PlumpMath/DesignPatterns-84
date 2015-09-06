namespace DesignPatterns.Behavioral.Implementation.CommandPattern.StructuralExample {
    /// <summary>
    /// Extends the Command interface, implementing the Execute method by invoking the corresponding operations on Receiver.
    /// It defines a link between the Receiver and the action.
    /// </summary>
    public class ConcreteCommand : Command {
        public ConcreteCommand(IReceiver receiver)
            : base(receiver) {

        }
        public override void Execute() {
            receiver.Action();
        }
    }
}
