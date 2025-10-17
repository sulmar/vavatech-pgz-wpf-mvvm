using Domain.Abstractions;
using Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;
using ViewModels;

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

        services.AddTransient<SensorsViewModel>();
        services.AddTransient<ISensorService, FakeSensorService>();

        services.AddTransient<RegionsViewModel>();
        services.AddTransient<IRegionService, FakeRegionService>();

        services.AddSingleton<ShellViewModel>();

        ServiceProvider = services.BuildServiceProvider();

        
    }
}

