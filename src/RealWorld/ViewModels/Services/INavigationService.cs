using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.Services;

public interface INavigationService
{
    void NavigateTo(string routeName);
    void RegisterRoute(string routeName, Type view);
}
