namespace Journal.Domain.Entities;

public class User : Entity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? Patronymic { get; set; }
    private string _fullName { get; set; }
    public string FullName
    {
        get => !string.IsNullOrEmpty(_fullName) ? _fullName : $"{LastName} {FirstName} {Patronymic}";
        set => _fullName = value;
    }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public Subject? Subjects { get; set; }
    public long? GroupId { get; set; }
}