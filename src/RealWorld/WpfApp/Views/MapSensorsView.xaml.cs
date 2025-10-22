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
using System.Windows.Media.Media3D;
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
        }

        private void Viewport3D_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var position = e.GetPosition(viewport);
            var hitParams = new PointHitTestParameters(position);

            var result =  VisualTreeHelper.HitTest(viewport, position);

            if (result is RayMeshGeometry3DHitTestResult meshHit)
            {
                if (meshHit.ModelHit == WallA)
                {

                }
                else if (meshHit.ModelHit == WallB)
                {

                }
            }


        }
    }
}
