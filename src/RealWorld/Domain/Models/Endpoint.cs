namespace Domain.Models;

public class Endpoint : BaseEntity
{
    public string Name { get; set; }
    public Category Category { get; set; }
    public bool IsActive { get; set; }

    public Endpoint()
    {
        IsActive = true;
    }
}


public enum Category
{
    P2P,
    Conference,
    Radionet
}