using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RestaurantManager.ViewModels
{
    //public class DelegateCommand:ICommand
    //{
    //    private readonly Action<object> _execute;
    //    private readonly Func<object, bool> _canExecute;
    //    public event EventHandler CanExecuteChanged;

    //    #region Constructors
    //    public DelegateCommand(Action<object> execute)
    //        : this(execute, null)
    //    {
    //    }

    //    public DelegateCommand(Action<object> execute, Func<object, bool> canExecute )
    //    {
    //        _execute = execute;
    //        _canExecute = canExecute;
    //    }
    //    #endregion Constructors

    //    #region ICommand Members
    //    bool ICommand.CanExecute(object parameter)
    //    {
    //        try
    //        {
    //            return CanExecute(parameter);
    //        }
    //        catch { return false; }
    //    }

    //    void ICommand.Execute(object parameter)
    //    {
    //        Execute(parameter);
    //    }
    //    #endregion ICommand Members

    //    #region Public Methods
    //    public bool CanExecute(object parameter)
    //    {
    //        if (_canExecute == null)
    //        {
    //            return true;
    //        }

    //        return _canExecute(parameter);
    //    }

    //    public void Execute(object parameter)
    //    {
    //        if (_execute != null)
    //        {
    //            _execute(parameter);
    //        }
    //    }

    //    public void RaiseCanExecuteChanged()
    //    {
    //        OnCanExecuteChanged(EventArgs.Empty);
    //    }
    //    #endregion Public Methods

    //    #region Protected Methods
    //    protected virtual void OnCanExecuteChanged(EventArgs e)
    //    {
    //        var handler = CanExecuteChanged;
    //        if (handler != null)
    //        {
    //            handler(this, e);
    //        }
    //    }

    //    #endregion Protected Methods
    //}

    public class DelegateCommand : ICommand
    {
        private readonly Action m_Execute;
        private readonly Func<bool> m_CanExecute;
        public event EventHandler CanExecuteChanged;

        public DelegateCommand(Action execute)
            : this(execute, () => true)
        { /* empty */ }

        public DelegateCommand(Action execute, Func<bool> canexecute)
        {
            if (execute == null)
                throw new ArgumentNullException("execute");
            m_Execute = execute;
            m_CanExecute = canexecute;
        }

        public bool CanExecute(object p)
        {
            return m_CanExecute == null ? true : m_CanExecute();
        }

        public void Execute(object p)
        {
            if (CanExecute(null))
                m_Execute();
        }

        public void RaiseCanExecuteChanged()
        {
            if (CanExecuteChanged != null)
                CanExecuteChanged(this, EventArgs.Empty);
        }
    }
}
