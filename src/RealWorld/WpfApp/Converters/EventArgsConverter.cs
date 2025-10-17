using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Input;

namespace WpfApp.Converters;

public class EventArgsConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        // Zawsze zwracaj null - ViewModel nie musi obsługiwać EventArgs
        return null;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
