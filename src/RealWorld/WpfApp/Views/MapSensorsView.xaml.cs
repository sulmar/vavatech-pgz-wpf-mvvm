using Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ViewModels;

namespace WpfApp.Views
{
    /// <summary>
    /// Interaction logic for MapSensorsView.xaml
    /// </summary>
    public partial class MapSensorsView : Page
    {
        public MapSensorsView()
        {
            InitializeComponent();

            this.DataContext = App.Current.ServiceProvider.GetRequiredService<SensorsViewModel>();
        }
    }
}
