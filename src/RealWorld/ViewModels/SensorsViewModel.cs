using Domain.Abstractions;
using Domain.Models.Sensors;

namespace ViewModels;

public class SensorsViewModel : ItemsViewModel<Sensor>
{
    public List<Sensor> Sensors => Items;

    public Sensor SelectedSensor { get; set; }

    public SensorsViewModel(ISensorService service)
    {
        Items = service.GetAll();

        SelectedSensor = Items.FirstOrDefault();
    }
}

