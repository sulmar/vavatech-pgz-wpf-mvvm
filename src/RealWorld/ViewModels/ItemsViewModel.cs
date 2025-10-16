using Domain.Models;

namespace ViewModels;

// Szablon (klasa generyczna)
public class ItemsViewModel<T> : BaseViewModel
        where T : Base
{
    public List<T> Items { get; set; }
}

