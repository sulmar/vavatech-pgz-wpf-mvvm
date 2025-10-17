using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp.Extensions;


public static class ControlAdapter
{
    // Metoda rozszerzajaca (Extension Method) klase Control (this musi byc pierwszy!)
    public static void SafeInvoke(this Control control, Action action)
    {
        //if (control.InvokeRequired)
        //{
        //    control.Invoke(action);
        //}
        //else
        //{
        //    action();
        //}
    }
}

// label1.SafeInvoke(()=>label1.Text = "Hello World!");
// textBox1.SafeInvoke(()=>textBox1.Text = "Hello World!");
