namespace DesignPatterns.Behavioral.Implementation.CommandPattern.StructuralExample {

    using System;

    public class Receiver : IReceiver{

        public void Action() {
            Console.WriteLine("Called Receiver.Action");
        }
    }
}
