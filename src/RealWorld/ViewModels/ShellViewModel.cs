using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ViewModels.Commands;

namespace ViewModels;


// Install-Package Microsoft.Xaml.Behaviors.Wpf
public class ShellViewModel : BaseViewModel
{
    public ShellViewModel()
    {
        ShowMapCommand = new RelayCommand(ShowMapSensors, CanShowMapSensors);
        ShowSensorsCommand = new RelayCommand(ShowSensors);
        ShowLogoCommand = new RelayCommand(ShowLogo);
    }

    public ICommand ShowMapCommand {  get; private set; }
    public ICommand ShowSensorsCommand { get; private set; }
    public ICommand ShowLogoCommand { get; set; }

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


    public void ShowLogo()
    {
        Console.WriteLine("Show logo!");
    }
}
