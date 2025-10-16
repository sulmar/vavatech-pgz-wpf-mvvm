using Domain.Abstractions;
using Domain.Models.Sensors;

namespace Infrastructure;

public class FakeSensorService : ISensorService
{
    public List<Sensor> GetAll()
    {
       return new List<Sensor>
        {
            new TemperatureSensor { Id = 1, IpAddress = "192.168.0.1", Name = "Czujnik temp. #1", X = 50, Y = 50 },
            new TemperatureSensor { Id = 2, IpAddress = "192.168.0.2", Name = "Czujnik temp. #2", X = 100, Y = 50 },
            new TemperatureSensor { Id = 3, IpAddress = "192.168.0.3", Name = "Czujnik temp. #3", X = 50, Y = 100 },
            new Gyroscope { Id = 4, IpAddress = "192.168.0.4", Name = "Zyroskop #1", X = 150, Y = 150  },
            new Gyroscope { Id = 5, IpAddress = "192.168.0.5", Name = "Zyroskop #2", X = 150, Y = 200  }
        };
    }
}

public class BFakeSensorService : FakeSensorService, ISensorService
{
    public new List<Sensor> GetAll()
    {
        var sensors = base.GetAll();

        var otherSensors = new List<Sensor>
        {
            new TemperatureSensor { Id = 1, IpAddress = "200.168.0.1", Name = "Czujnik temp. #1"},
            new TemperatureSensor { Id = 2, IpAddress = "200.168.0.2", Name = "Czujnik temp. #2"},
            new TemperatureSensor { Id = 3, IpAddress = "200.168.0.3", Name = "Czujnik temp. #3"},            
            new Gyroscope { Id = 5, IpAddress = "200.168.0.5", Name = "Zyroskop #2" }
        };

        return sensors.Union(otherSensors).ToList();
    }
}