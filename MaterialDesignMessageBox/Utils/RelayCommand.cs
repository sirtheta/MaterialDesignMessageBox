using System;
using System.Diagnostics;
using System.Windows.Input;

namespace MaterialDesignMessageBoxSirTheta
{
  public class RelayCommand<T> : ICommand
  {
    #region Members
    readonly Action<T> _Execute = null;
    readonly Predicate<T> _CanExecute = null;
    #endregion


    #region Constructors
    public RelayCommand(Action<T> Execute) : this(Execute, null) { }

    /// <summary>
    /// Creates a new command
    /// </summary>
    /// <param name="Execute">Execution logic</param>
    /// <param name="CanExecute">Execution status logic</param>
    public RelayCommand(Action<T> Execute, Predicate<T> CanExecute)
    {
      _Execute = Execute ?? throw new ArgumentNullException("Execute");
      _CanExecute = CanExecute;
    }
    #endregion


    #region ICommand Members
    [DebuggerStepThrough]
    public bool CanExecute(object Parameter) => _CanExecute == null ? true : _CanExecute((T)Parameter);


    public event EventHandler CanExecuteChanged
    {
      add
      {
        CommandManager.RequerySuggested += value;
      }
      remove
      {
        CommandManager.RequerySuggested -= value;
      }
    }

    public void Execute(object Parameter) => _Execute((T)Parameter);
    #endregion

  }
}
