using Domain.Abstractions;
using Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;
using ViewModels;
using ViewModels.Services;
using WpfApp.Services;
using WpfApp.Views;

namespace WpfApp;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{

    // Install-Package Microsoft.Extensions.DependencyInjection

    public IServiceProvider ServiceProvider { get; }

    public new static App Current => (App)Application.Current;

    public App()
    {

        var services = new ServiceCollection();


        services.AddTransient<MapSensorsView>();
        services.AddTransient<SensorsView>();

        services.AddTransient<SensorsViewModel>();
        services.AddTransient<ISensorService, FakeSensorService>();

        services.AddTransient<RegionsViewModel>();
        services.AddTransient<IRegionService, FakeRegionService>();

        services.AddSingleton<ShellViewModel>();
        services.AddSingleton<INavigationService, FrameNavigationService>();


        services.AddSingleton<EndpointsView>();
        services.AddSingleton<EndpointsViewModel>();
        services.AddSingleton<IEndpointService, FakeEndpointService>();

        ServiceProvider = services.BuildServiceProvider();


        var navigationService = ServiceProvider.GetRequiredService<INavigationService>();
        navigationService.RegisterRoute("Map", typeof(MapSensorsView));
        navigationService.RegisterRoute("Sensors", typeof(SensorsView));
        navigationService.RegisterRoute("Endpoints", typeof(EndpointsView));



    }
}

