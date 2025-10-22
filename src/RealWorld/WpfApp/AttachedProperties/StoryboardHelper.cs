using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace WpfApp.AttachedProperties;

/*

<UserControl x:Class="FadeOutDemo.MyItem"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">
    <Grid x:Name="Root" Background="LightBlue">
        <TextBlock Text = "Element" HorizontalAlignment="Center" VerticalAlignment="Center"/>
    </Grid>
</UserControl>


public void FadeOutAndExecute(Action onComplete)
{
    var anim = new DoubleAnimation(1, 0, new Duration(TimeSpan.FromSeconds(0.5)));
    anim.Completed += (s, e) => onComplete?.Invoke();
    Root.BeginAnimation(UIElement.OpacityProperty, anim);
}



myItem.FadeOutAndRemove(() =>
{
    MyItems.Remove(myItem); // dopiero po zakończeniu animacji
});

*/


public static class StoryboardHelper
{
    public static readonly DependencyProperty PlayProperty =
        DependencyProperty.RegisterAttached(
            "Play",
            typeof(Storyboard),
            typeof(StoryboardHelper),
            new PropertyMetadata(null, OnPlayChanged));

    public static void SetPlay(DependencyObject element, Storyboard value) => element.SetValue(PlayProperty, value);
    public static Storyboard GetPlay(DependencyObject element) => (Storyboard)element.GetValue(PlayProperty);

    private static void OnPlayChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is FrameworkElement fe && e.NewValue is Storyboard sb)
        {
            Storyboard.SetTarget(sb, fe);
            sb.Begin();
        }
    }

    public static readonly DependencyProperty OnCompletedCommandProperty =
        DependencyProperty.RegisterAttached(
            "OnCompletedCommand",
            typeof(ICommand),
            typeof(StoryboardHelper),
            new PropertyMetadata(null));

    public static void SetOnCompletedCommand(DependencyObject element, ICommand value) => element.SetValue(OnCompletedCommandProperty, value);
    public static ICommand GetOnCompletedCommand(DependencyObject element) => (ICommand)element.GetValue(OnCompletedCommandProperty);

    public static void AttachCompletedHandler(Storyboard sb, FrameworkElement fe)
    {
        sb.Completed += (s, e) =>
        {
            var command = GetOnCompletedCommand(fe);
            if (command?.CanExecute(null) == true)
                command.Execute(null);
        };
    }
}
