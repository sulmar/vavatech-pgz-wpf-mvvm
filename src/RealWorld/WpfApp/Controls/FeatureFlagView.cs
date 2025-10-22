using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp.Controls;

public class FeatureFlagView : ContentControl
{
    public string Feature
    {
        get { return (string)GetValue(FeatureProperty); }
        set { SetValue(FeatureProperty, value); }
    }

    // Using a DependencyProperty as the backing store for Feature.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty FeatureProperty =
        DependencyProperty.Register("Feature", typeof(string), typeof(FeatureFlagView), new PropertyMetadata(null, OnFeatureChanged));

    private static void OnFeatureChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is FeatureFlagView view)
            view.UpdateVisibility();
    }

    private void UpdateVisibility()
    {
        if (FeatureFlagService.IsEnabled(Feature))
        {
            Visibility = Visibility.Visible;
        }
        else
        {
            Visibility = Visibility.Collapsed;
        }

    }
}
