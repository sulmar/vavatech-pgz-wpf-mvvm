using Domain.Models.Sensors;

namespace Domain.Abstractions;

public interface ISensorService
{
    List<Sensor> GetAll();
}
