using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ViewModels.Commands;

namespace ViewModels;

public class ShellViewModel : BaseViewModel
{
    public ShellViewModel()
    {
        ShowMapCommand = new RelayCommand(ShowMapSensors, CanShowMapSensors);
        ShowSensorsCommand = new RelayCommand(ShowSensors);
    }

    public ICommand ShowMapCommand {  get; private set; }
    public ICommand ShowSensorsCommand { get; private set; }

    public void ShowMapSensors()
    {
        Console.WriteLine("Show map sensors!");
    }

    public bool CanShowMapSensors()
    {
        return true;
    }

    public void ShowSensors()
    {
        Console.WriteLine("Show sensors!");
    }
}
