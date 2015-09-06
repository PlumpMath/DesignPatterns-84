namespace DesignPatterns.Behavioral.Implementation.ChainOfResponsibilityPattern {

    using System;

    public class CriticalIssueHandler : Handler{
        public override void HandleRequest(IRequest request) {
            if (request.Priority == PriorityType.Critical) {

                // Handle the request
                Console.WriteLine("{0} handler request# {1}", this.GetType().Name, request.TokenNumber);

            } else if (Successor != null) {
                Successor.HandleRequest(request);
            }
        }
    }
}
