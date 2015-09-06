namespace DesignPatterns.Behavioral.Implementation.CommandPattern.StructuralExample {

    using System;

    /// <summary>
    /// Asks the command to carry out the request
    /// </summary>
    public class Invoker {
        private Command _command;

        public void SetCommand(Command command) {
            this._command = command;
        }

        public void ExecuteCommand() {
            if (_command == null)
                throw new InvalidOperationException();

            this._command.Execute();
        }
    }
}
