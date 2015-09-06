namespace DesignPatterns.Behavioral.Implementation.CommandPattern.StructuralExample {
    public class Client {
        public static void Main() {
            IReceiver receiver = new Receiver();
            Command command = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker();

            invoker.SetCommand(command);
            invoker.ExecuteCommand();
        }
    }
}
