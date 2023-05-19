namespace Domain.Entities;

public sealed class Reminder : Entity
{
    public Member Starter { get; private set; }
    public Member Responsible { get; private set; }
    public Member Prayer { get; private set; }
    public string BookPage { get; private set; } = string.Empty;
    public string PdfPage { get; private set; } = string.Empty;
    public string Paragraph { get; private set; } = string.Empty;
    public string? Observation { get; private set; }

    public DateTime CreationDate { get; set; }
    public DateTime Date { get; set; }

#pragma warning disable CS8618
    private Reminder() { }
#pragma warning restore CS8618

    public Reminder(Member starter,
        Member responsible,
        Member prayer,
        string bookPage,
        string pdfPage,
        string paragraph,
        string? observation,
        DateTime date)
    {
        Starter = starter;
        Responsible = responsible;
        Prayer = prayer;
        BookPage = bookPage;
        PdfPage = pdfPage;
        Paragraph = paragraph;
        Observation = observation;
        Date = date;
        CreationDate = DateTime.Now;
    }
}