using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Input;

namespace WpfApp.Converters;

public class EventToCommandConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is ICommand command)
        {
            return new EventHandler((sender, e) =>
            {
                if (command.CanExecute(null))
                    command.Execute(null);
            });
        }
        return null;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
