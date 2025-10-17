using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using ViewModels.Services;

namespace WpfApp.Services;

class FrameNavigationService : INavigationService
{
    private readonly IDictionary<string, Type> routes = new Dictionary<string, Type>();

    public void NavigateTo(string viewName)
    {
        Frame frame = GetFrame("MainFrame");

        Type typeView = routes[viewName];

        var view = App.Current.ServiceProvider.GetRequiredService(typeView);

        frame.Navigate(view);
    }

    public void RegisterRoute(string routeName, Type viewType)
    {
       routes.Add(routeName, viewType);
    }

    private Frame GetFrame(string name)
    {
        if (Application.Current.MainWindow.FindName(name) is Frame frame)
            return frame;

        throw new KeyNotFoundException();
    }
}
