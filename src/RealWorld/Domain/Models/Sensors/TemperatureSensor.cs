namespace Domain.Models.Sensors;

public partial class TemperatureSensor : Sensor
{
    public float Value { get; set; }

    public const int Threshold = 100;
    public bool IsOverLimit => Value > Threshold;
}
