using Domain.Enums;

namespace Domain.Entities;

public sealed class Group : Entity
{
    public ExternalId ExternalId { get; private set; }
    public string Name { get; private set; } = string.Empty;

    public ReadingPlan? DefaultReadingPlan { get; private set; }
    
    public IReadOnlyList<Member> Members => _members.AsReadOnly();
    public IReadOnlyList<Book> Books => _books.AsReadOnly();
    public IReadOnlyList<ReadingPlan> ReadingPlans => _readingPlans.AsReadOnly();
    private List<Member> _members = new();
    private List<Book> _books = new();
    private List<ReadingPlan> _readingPlans = new();

    public bool ThereIsActiveReadingPlan => DefaultReadingPlan != null;

    public Group(string name, string token, Source source)
    {
        ExternalId = new(token, source);
        Name = name;
    }

    public void SetReadingDefaultReadingPlan(ReadingPlan readingPlan)
    {
        if (!_readingPlans.Contains(readingPlan))
            _readingPlans.Add(readingPlan);
        DefaultReadingPlan = readingPlan;
    }

    public void AddMember(Member member)
    {
        _members.Add(member);
    }

    public void AddMember(List<Member> members)
    {
        _members.AddRange(members);
    }
    
    public void AddBook(Book book) => _books.Add(book);