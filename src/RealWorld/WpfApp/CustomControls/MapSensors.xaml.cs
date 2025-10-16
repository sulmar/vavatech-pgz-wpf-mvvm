using Domain.Models.Sensors;
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

namespace WpfApp.CustomControls
{
    /// <summary>
    /// Interaction logic for MapSensors.xaml
    /// </summary>
    public partial class MapSensors : UserControl
    {
        public MapSensors()
        {
            InitializeComponent();
        }

        public IEnumerable<Sensor> ItemsSource
        {
            get { return (IEnumerable<Sensor>)GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }

        public static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register("ItemsSource", typeof(IEnumerable<Sensor>), typeof(MapSensors));


    }


   
}
