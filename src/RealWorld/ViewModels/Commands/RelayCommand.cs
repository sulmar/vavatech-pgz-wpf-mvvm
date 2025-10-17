using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace ViewModels.Commands;

// Adapter Pattern

// RelayCommand bez obslugi parametrow
public class RelayCommand : ICommand
{
    private readonly Action execute;
    private readonly Func<bool> canExecute;

    public RelayCommand(Action execute, Func<bool> canExecute = null)
    {
        this.execute = execute;
        this.canExecute = canExecute;
    }

    public event EventHandler? CanExecuteChanged;

    public bool CanExecute(object? parameter)
    {
        return canExecute == null || canExecute();
    }

    public void Execute(object? parameter)
    {
        execute?.Invoke();
    }
}

// RelayCommand / DelegateCommand

/*
public class RelayCommand : ICommand
{
    private readonly Action<object?> execute;
    private readonly Func<object?, bool> canExecute;

    public RelayCommand(Action<object?> execute, Func<object?, bool> canExecute = null)
    {
        this.execute = execute;
        this.canExecute = canExecute;
    }

    public event EventHandler? CanExecuteChanged;

    public bool CanExecute(object? parameter)
    {
        return canExecute == null || canExecute(parameter);
    }

    public void Execute(object? parameter)
    {        
        execute?.Invoke(parameter);        
    }

}

*/




