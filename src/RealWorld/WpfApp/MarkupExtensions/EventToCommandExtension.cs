using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Markup;

namespace WpfApp.MarkupExtensions;

public class EventToCommandExtension : MarkupExtension
{
    public ICommand Command { get; set; }

    public EventToCommandExtension(ICommand command)
    {
        this.Command  = command;
    }

    // TODO: zaimplementowac
    public override object ProvideValue(IServiceProvider serviceProvider)
    {
        throw new NotImplementedException();
    }
}
