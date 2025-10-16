using Domain.Abstractions;
using Domain.Models;
using Domain.Models.Sensors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels;

public class RegionsViewModel : ItemsViewModel<Region>
{
    public List<Region> Regions => Items;

    public RegionsViewModel(IRegionService service)
    {
        Items = service.GetAll();
    }

}
