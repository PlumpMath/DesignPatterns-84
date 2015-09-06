namespace DesignPatterns.Behavioral.Implementation.ChainOfResponsibilityPattern {
    public class Request : IRequest {
        public Request(int token, PriorityType priority) {
            this.TokenNumber = token;
            this.Priority = priority;
        }
        public int TokenNumber { get; set; }
        public PriorityType Priority { get; set; }
    }
}
