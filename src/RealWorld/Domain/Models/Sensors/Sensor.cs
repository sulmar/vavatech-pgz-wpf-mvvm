namespace Domain.Models.Sensors;

public abstract class Sensor : BaseEntity
{
    public string Name { get; set; }
    public string IpAddress { get; set; }

    public override string ToString()
    {
        return $"{Name} {IpAddress}";
    }
}
