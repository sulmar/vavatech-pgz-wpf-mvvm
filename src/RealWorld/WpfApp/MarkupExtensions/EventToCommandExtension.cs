using System;
using System.Reflection;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;

namespace WpfApp.MarkupExtensions;

public class EventToCommandExtension : MarkupExtension
{
    public string CommandPath { get; set; }

    public override object ProvideValue(IServiceProvider serviceProvider)
    {
        if (string.IsNullOrEmpty(CommandPath))
            return null;

        var targetProvider = serviceProvider.GetService(typeof(IProvideValueTarget)) as IProvideValueTarget;
        var targetElement = targetProvider?.TargetObject as FrameworkElement;
        
        if (targetElement?.DataContext == null)
            return null;

        var command = GetCommand(targetElement.DataContext, CommandPath);
        if (command == null)
            return null;

        // Dla eventów myszy zwróć MouseEventHandler
        return new MouseEventHandler((sender, e) =>
        {
            if (command.CanExecute(null))
                command.Execute(null);
        });
    }

    private ICommand GetCommand(object dataContext, string commandPath)
    {
        var property = dataContext.GetType().GetProperty(commandPath);
        return property?.GetValue(dataContext) as ICommand;
    }
}
