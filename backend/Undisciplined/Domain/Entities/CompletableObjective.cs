namespace Undisciplined.Domain;

public class CompletableObjective
{
    public Guid Id { get; set; }
    public Objective Objective { get; set; }
    public ObjectiveStatus Status { get; set; } = ObjectiveStatus.Incomplete;
}

public enum ObjectiveStatus
{
    Complete,
    Incomplete
}

