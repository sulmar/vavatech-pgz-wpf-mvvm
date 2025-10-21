using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace WpfApp;

public class ViewModelLocator
{
    public SensorsViewModel SensorsViewModel => App.Current.ServiceProvider.GetRequiredService<SensorsViewModel>();
    public RegionsViewModel RegionsViewModel => App.Current.ServiceProvider.GetRequiredService<RegionsViewModel>();
    public EndpointsViewModel EndpointsViewModel => App.Current.ServiceProvider.GetRequiredService<EndpointsViewModel>();
    public ShellViewModel ShellViewModel => App.Current.ServiceProvider.GetRequiredService<ShellViewModel>();
}
