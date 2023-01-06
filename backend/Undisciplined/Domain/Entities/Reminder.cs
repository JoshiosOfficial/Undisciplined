namespace Undisciplined.Domain;

public class Reminder
{
    public Guid Id { get; set; }
    public Task Task { get; set; }
    public DateTime OccursAt { get; set; }
    public ReminderStatus Status { get; set; } = ReminderStatus.Inactive;
    public List<CompletableObjective> Objectives { get; set; }
}

public enum ReminderStatus
{
    Complete,
    Active,
    Inactive,
    Failed
}