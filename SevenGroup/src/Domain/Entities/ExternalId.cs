using Domain.Enums;

namespace Domain.Entities;

public sealed class ExternalId : Entity
{
    public string Token { get; private set; } = string.Empty;
    public Source Source { get; private set; }

#pragma warning disable CS8618
    private ExternalId() { }
#pragma warning restore CS8618

    public ExternalId(string token, Source source)
    {
        Token = token;
        Source = source;
    }
}