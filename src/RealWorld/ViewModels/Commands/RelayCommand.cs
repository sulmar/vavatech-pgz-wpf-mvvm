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

    public void OnCanExecuteChanged()
    {
        CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }

    public bool CanExecute(object? parameter)
    {
        return canExecute == null || canExecute();
    }

    public void Execute(object? parameter)
    {
        execute?.Invoke();
    }
}

// RelayCommand z obsługą parametrów
public class RelayCommand<T> : ICommand
{
    private readonly Action<T> execute;
    private readonly Func<T, bool> canExecute;

    public RelayCommand(Action<T> execute, Func<T, bool> canExecute = null)
    {
        this.execute = execute;
        this.canExecute = canExecute;
    }

    public event EventHandler? CanExecuteChanged;

    public bool CanExecute(object? parameter)
    {
        if (canExecute == null)
            return true;
            
        // Bezpieczne rzutowanie - obsługa null
        try
        {
            return canExecute((T)parameter);
        }
        catch
        {
            return false;
        }
    }

    public void Execute(object? parameter)
    {
        try
        {
            execute?.Invoke((T)parameter);
        }
        catch (Exception ex)
        {
            // Log error or handle gracefully
            System.Diagnostics.Debug.WriteLine($"Error executing command: {ex.Message}");
        }
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




