using Domain.Models.Sensors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models;

public class Region : BaseEntity
{
    public string Name { get; set; }
    public List<Sensor> Sensors { get; set; }
}
