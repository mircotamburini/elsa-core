using Elsa.Services.Models;

namespace Elsa.ActivityResults
{
    public class FaultResult : ActivityExecutionResult
    {
        public FaultResult(string message) => Message = message;
        public string Message { get; set; }
        public string? StackTrace { get; set; }
        
        protected override void Execute(ActivityExecutionContext activityExecutionContext) => 
            activityExecutionContext.WorkflowExecutionContext.Fault(activityExecutionContext.ActivityBlueprint.Id, Message, StackTrace, activityExecutionContext.Input, activityExecutionContext.Resuming);
    }
}