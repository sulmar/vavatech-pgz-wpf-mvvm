using Domain.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfApp.Converters;

class CategoryToBrushConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is Category category)
        {
            // Match Pattern
            var color  = category switch
            {
                Category.P2P => Colors.Violet,
                Category.Conference => Colors.Blue,   
                Category.Radionet => Colors.Green,
                _ => Colors.Red,
            };

            return new SolidColorBrush(color);
        }

        return value;

    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
