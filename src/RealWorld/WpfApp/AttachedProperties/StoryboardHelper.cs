using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace WpfApp.AttachedProperties;

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
