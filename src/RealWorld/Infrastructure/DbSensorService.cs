using Domain.Abstractions;
using Domain.Models.Sensors;

namespace Infrastructure;

public class DbSensorService : ISensorService
{
    public List<Sensor> GetAll()
    {
        throw new NotImplementedException();
    }
}