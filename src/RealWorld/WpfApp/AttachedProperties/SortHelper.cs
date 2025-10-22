using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace WpfApp.AttachedProperties;


public static class SortHelper 
{
    public static readonly DependencyProperty PropertyNameProperty =
        DependencyProperty.RegisterAttached("PropertyName", typeof(string), typeof(SortHelper), 
            new PropertyMetadata(null, OnSortPropertyNameChanged));

    public static void SetPropertyName(DependencyObject obj, string value) => obj.SetValue(PropertyNameProperty, value);
    public static string GetPropertyName(DependencyObject obj) => (string) obj.GetValue(PropertyNameProperty);

    private static void OnSortPropertyNameChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is not ItemsControl control)
            return;

        var propertyName = GetPropertyName(control);
        if (propertyName == null) return;

        //var view = CollectionViewSource.GetDefaultView(control.ItemsSource);
        //if (view == null) return;

        void ApplySort()
        {
            var items = control.Items;

            items.SortDescriptions.Clear();
            items.SortDescriptions.Add(new System.ComponentModel.SortDescription(propertyName, System.ComponentModel.ListSortDirection.Ascending));
            control.Items.Refresh();
        }

        if (control.IsLoaded)
            ApplySort();
        else
        {
            RoutedEventHandler? once = null;
            once = (_, __) =>
            {
                control.Loaded -= once;
                ApplySort();
            };

            control.Loaded += once; 
        }

    }
}
