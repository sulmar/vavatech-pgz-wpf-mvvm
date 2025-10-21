using Domain.Abstractions;
using Domain.Models;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using System.ComponentModel;
using ViewModels.Commands;

namespace ViewModels;

public class EndpointsViewModel : BaseViewModel
{
    private readonly IEndpointService service;


    private const int PageSize = 6;

    private int _currentPage;
    public int CurrentPage 
    { 
        get => _currentPage;
        set
        {
            if (_currentPage != value)
            {
                _currentPage = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(EndPointsPaged));
                OnPropertyChanged(nameof(CanPrevPage));
                OnPropertyChanged(nameof(CanNextPage));

                NextPageCommand.OnCanExecuteChanged();
                PrevPageCommand.OnCanExecuteChanged();
            }
        }
    }

    public List<Endpoint> EndPoints { get; set; }    

    public List<Endpoint> EndPointsPaged => EndPoints.Skip(CurrentPage * PageSize).Take(PageSize).ToList();

    public int TotalPages => (int) Math.Ceiling((double) EndPoints.Count / PageSize);

    public RelayCommand NextPageCommand => new RelayCommand(NextPage);
    public RelayCommand PrevPageCommand => new RelayCommand(PrevPage);

    public EndpointsViewModel(IEndpointService service)
    {
        this.service = service;

        EndPoints =(service.GetAll());

        Customer customer1 = new Customer { FirstName = "John", LastName = "Smith", Email = "john@domain.com" };

        foreach (var property in customer1)
        {
            Debug.WriteLine(property);
        }
                

    }


    public bool CanNextPage => CurrentPage < TotalPages - 1;
    public void NextPage()
    {
        if (CanNextPage)
            CurrentPage++;
    }

    public bool CanPrevPage => CurrentPage > 0;
    public void PrevPage()
    {
        if (CanPrevPage)
            CurrentPage--;
    }
}
