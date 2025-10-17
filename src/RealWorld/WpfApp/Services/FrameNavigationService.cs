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
    public void NavigateTo(string viewName)
    {
        Frame frame = GetFrame("MainFrame");

        Type typeView = Type.GetType($"WpfApp.Views.{viewName}");

        var view = App.Current.ServiceProvider.GetRequiredService(typeView);

        frame.Navigate(view);
    }

    private Frame GetFrame(string name)
    {
        if (Application.Current.MainWindow.FindName(name) is Frame frame)
            return frame;

        throw new KeyNotFoundException();
    }
}
