using Microsoft.Xaml.Behaviors;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp.Behaviors;

class MouseCoordinateBehavior : Behavior<Canvas>
{

    public double X
    {
        get { return (double)GetValue(XProperty); }
        set { SetValue(XProperty, value); }
    }

    // Using a DependencyProperty as the backing store for X.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty XProperty =
        DependencyProperty.Register("X", typeof(double), typeof(MouseCoordinateBehavior), 
            new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

    public double Y
    {
        get { return (double)GetValue(YProperty); }
        set { SetValue(YProperty, value); }
    }

    // Using a DependencyProperty as the backing store for Y.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty YProperty =
        DependencyProperty.Register("Y", typeof(double), typeof(MouseCoordinateBehavior),
             new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));




    protected override void OnAttached()
    {
        base.OnAttached();

        AssociatedObject.MouseMove += AssociatedObject_MouseMove;
    }

    private void AssociatedObject_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
    {
        var position = e.GetPosition(AssociatedObject);

        X = position.X;
        Y = position.Y;        

        Debug.WriteLine($"{position.X}, {position.Y}");
    }

    protected override void OnDetaching()
    {
        base.OnDetaching();

        AssociatedObject.MouseMove -= AssociatedObject_MouseMove;   
    }
}
