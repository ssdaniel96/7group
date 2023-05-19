namespace Domain.Entities;

public sealed class ReadingPlan : Entity
{
    public string Name { get; private set; } = string.Empty;
    public Book Book { get; private set; }
    public DateTime CreationDate { get; private set; }
    
    public IReadOnlyList<Reminder> Reminders => _reminders.AsReadOnly();
    private List<Reminder> _reminders = new();
    public Reminder ActualReminder => Reminders.Last();
    
#pragma warning disable CS8618
    private ReadingPlan(){}
#pragma warning restore CS8618
    
    public ReadingPlan(Book book, string name)
    {
        Book = book;
        Name = name;
        CreationDate = DateTime.Now;
    }

    
}