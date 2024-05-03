namespace Journal.Domain.Entities;

public class Subject : Entity
{
    public string Caption { get; set; }
    public long UserId { get; set; }
}