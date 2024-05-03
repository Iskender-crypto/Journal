namespace Journal.Domain.Entities;

public class Journal : Entity
{
    public List<string> JournalDay { get; set; }
    public List<string> JournalText { get; set; }
    public string Semestr { get; set; }
    public long UserId { get; set; }
}