using Domain.Models;
using Domain.Models.Sensors;

namespace Domain.Abstractions;

public interface ISensorService
{
    List<Sensor> GetAll();
}


public interface IRegionService
{
    List<Region> GetAll();
}