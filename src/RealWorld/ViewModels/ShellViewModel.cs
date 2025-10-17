using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ViewModels.Commands;
using ViewModels.Services;

namespace ViewModels;


// Install-Package Microsoft.Xaml.Behaviors.Wpf
public class ShellViewModel : BaseViewModel
{
    private readonly INavigationService navigationService;

    public ShellViewModel(INavigationService navigationService)
    {
        this.navigationService = navigationService;

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

        navigationService.NavigateTo("Map");
    }

    public bool CanShowMapSensors()
    {
        return true;
    }

    public void ShowSensors()
    {
        Console.WriteLine("Show sensors!");

        navigationService.NavigateTo("Sensors");
    }


    public void ShowLogo()
    {
        Console.WriteLine("Show logo!");
    }
}
