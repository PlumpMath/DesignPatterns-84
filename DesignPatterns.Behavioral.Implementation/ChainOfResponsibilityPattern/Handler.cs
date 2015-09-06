namespace DesignPatterns.Behavioral.Implementation.ChainOfResponsibilityPattern {
    public abstract class Handler {
        public Handler Successor { protected get; set; }
        public abstract void HandleRequest(IRequest request);
    }
}
