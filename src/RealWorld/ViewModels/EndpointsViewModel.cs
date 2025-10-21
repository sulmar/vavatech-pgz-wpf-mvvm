using Domain.Abstractions;
using Domain.Models;
using System.Windows.Input;
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
            }
        }
    }

    public List<Endpoint> EndPoints { get; set; }

    public List<Endpoint> EndPointsPaged => EndPoints.Skip(CurrentPage * PageSize).Take(PageSize).ToList();

    public int TotalPages => (int) Math.Ceiling((double) EndPoints.Count / PageSize);

    public ICommand NextPageCommand => new RelayCommand(NextPage);
    public ICommand PrevPageCommand => new RelayCommand(PrevPage);

    public EndpointsViewModel(IEndpointService service)
    {
        this.service = service;

        EndPoints = service.GetAll();
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
