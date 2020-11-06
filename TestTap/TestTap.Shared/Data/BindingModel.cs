using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace TestTap.Shared.Data
{
    public class BindingModel : INotifyPropertyChanged
    {

        //protected readonly ValidationHandler _validationHandler = new ValidationHandler();

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        protected void EvRaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }



        #endregion

        public class DelegateCommand<T> : ICommand
        {
            private readonly Action<T> executeAction;
            Func<object, bool> canExecute;

            public event EventHandler CanExecuteChanged;

            public DelegateCommand(Action<T> executeAction)
                : this(executeAction, null)
            {
            }

            public DelegateCommand(Action<T> executeAction, Func<object, bool> canExecute)
            {
                this.executeAction = executeAction;
                this.canExecute = canExecute;
            }

            public bool CanExecute(object parameter)
            {
                return canExecute == null ? true : canExecute(parameter);
            }

            public void Execute(object parameter)
            {
                executeAction((T)parameter);
            }
            public void RaiseCanExecuteChanged()
            {
                EventHandler handler = this.CanExecuteChanged;
                if (handler != null)
                {
                    handler(this, new EventArgs());
                }
            }
        }
    }
}
