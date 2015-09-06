namespace DesignPatterns.Behavioral.Implementation.ChainOfResponsibilityPattern {
    public class Client {
        public static void Main() {
            Handler minorIssueHandler = new MinorIssueHandler();
            Handler normalIssueHandler = new NormalIssueHandler();
            Handler criticalIssueHandler = new CriticalIssueHandler();

            minorIssueHandler.Successor = normalIssueHandler;
            normalIssueHandler.Successor = criticalIssueHandler;

            minorIssueHandler.HandleRequest(new Request(1, PriorityType.Minor));
            minorIssueHandler.HandleRequest(new Request(2, PriorityType.Normal));
            minorIssueHandler.HandleRequest(new Request(3, PriorityType.Critical));
        }
    }
}
