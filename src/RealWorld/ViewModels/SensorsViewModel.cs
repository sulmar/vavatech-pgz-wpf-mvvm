using Domain.Models;
using Domain.Models.Sensors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels;

public abstract class BaseViewModel
{

}

// Szablon (klasa generyczna)
public class ItemsViewModel<T> : BaseViewModel
        where T : Base
{
    public List<T> Items { get; set; }
}



public class SensorsViewModel : ItemsViewModel<Sensor>
{
    public List<Sensor> Sensors => Items;
}


public class CustomersViewModel : ItemsViewModel<Customer>
{
}

