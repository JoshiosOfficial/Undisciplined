namespace Undisciplined.Domain;

public class Task
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public List<Objective> Objectives { get; set; }
    public List<Reminder> Reminders { get; set; }
    public TimeOnly StartsAt { get; set; }
    public TimeSpan ExpiresAfter { get; set; }
}