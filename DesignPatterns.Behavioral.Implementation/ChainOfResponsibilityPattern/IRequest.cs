namespace DesignPatterns.Behavioral.Implementation.ChainOfResponsibilityPattern {
    public interface IRequest {
        int TokenNumber { get; set; }
        PriorityType Priority { get; set; }
    }

    public enum PriorityType {
        Minor,
        Normal,
        Critical
    }
}
