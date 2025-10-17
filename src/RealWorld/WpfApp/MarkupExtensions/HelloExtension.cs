using System.Windows.Markup;

namespace WpfApp.MarkupExtensions;

public class HelloExtension : MarkupExtension
{
    public string Text { get; set; }

    public HelloExtension()
    {
        
    }

    public HelloExtension(string text)
    {
        Text = text;
    }

    public override object ProvideValue(IServiceProvider serviceProvider)
    {
        if (string.IsNullOrEmpty(Text))
        {
            return "Hello custom Markup Extension";
        }
        else
            return $"Hello {Text}";
    }
}
