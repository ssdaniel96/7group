namespace Domain.Entities;

public sealed class Book : Entity
{
    public string Name { get; private set; } = string.Empty;
    public string? Author { get; private set; }
    public int TotalPages { get; private set; }
    public int TotalChapters { get; private set; }
    public Uri? SourceUrl { get; private set; }

#pragma warning disable CS8618
    private Book()
#pragma warning restore CS8618
    {
        
    }
    
    public Book(string name, string? author, int totalPages, int totalChapters, Uri? sourceUrl)
    {
        Name = name;
        Author = author;
        TotalPages = totalPages;
        TotalChapters = totalChapters;
        SourceUrl = sourceUrl;
    }
}