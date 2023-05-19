namespace Domain.Entities;

public sealed class Member : Entity
{
    public string Name { get; private set; } = string.Empty;
    public bool IsActive { get; private set; }

#pragma warning disable CS8618
    private Member()
#pragma warning restore CS8618
    {
        
    }
    
    public Member(string name)
    {
        Name = name;
        IsActive = true;
    }
}