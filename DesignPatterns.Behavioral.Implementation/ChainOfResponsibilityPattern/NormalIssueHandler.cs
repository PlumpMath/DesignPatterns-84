namespace DesignPatterns.Behavioral.Implementation.ChainOfResponsibilityPattern {

    using System;
    
    public class NormalIssueHandler : Handler {
        public override void HandleRequest(IRequest request) {
            if (request.Priority == PriorityType.Normal) {

                // Handle the request
                Console.WriteLine("{0} handler request# {1}", this.GetType().Name, request.TokenNumber);

            } else if (Successor != null) {
                Successor.HandleRequest(request);
            }
        }
    }
}
