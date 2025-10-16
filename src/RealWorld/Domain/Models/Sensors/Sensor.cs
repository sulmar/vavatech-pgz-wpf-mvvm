namespace Domain.Models.Sensors;

public abstract class Sensor : BaseEntity
{
    public string Name { get; set; }
    public string IpAddress { get; set; }

    public string FullName => $"{Name} {IpAddress}";

    public override string ToString()
    {
        return FullName;
    }
}
