namespace Domain.Models.Sensors;

public class TemperatureSensor : Sensor
{
    // backfield
    private float _Value;
    public float Value
    {
        get => _Value;
        set
        {
            _Value = value;

            OnPropertyChanged();
            OnPropertyChanged(nameof(IsOverLimit));
        }
    }

    // backfield
    private string field;
    public string Message
    {
        get => field;
        set
        {
            field = value;

            OnPropertyChanged();
        }

    }

    // C# 14
    //public string Message
    //{
    //    get;
    //    set
    //    {
    //        field = value;

    //        OnPropertyChanged("Message");
    //    }

    //}


    public const int Threshold = 100;

    public bool IsOverLimit => Value > Threshold;
}
