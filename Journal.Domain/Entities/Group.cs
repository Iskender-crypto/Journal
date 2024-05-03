namespace Journal.Domain.Entities;

public class Group : Entity
{
    public long? UserId { get; set; }
    public string Caption { get; set; }
    public List<User>? Students { get; set; }
    
}