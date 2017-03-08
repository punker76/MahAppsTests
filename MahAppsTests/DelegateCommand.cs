using System;
using System.Windows.Input;


namespace MahAppsTests
{
	public class DelegateCommand : ICommand
	{
		private readonly Action<object> execute;
		private readonly Func<object, bool> canExecute;


		public DelegateCommand(Action<object> execute, Func<object, bool> canExecute = null) {
			if (execute == null)
				throw new ArgumentNullException(nameof(execute));
			this.execute = execute;
			this.canExecute = canExecute;
		}


		public bool CanExecute(object parameter) {
			return canExecute?.Invoke(parameter) ?? true;
		}

		public void Execute(object parameter) {
			execute(parameter);
		}


		public void RaiseCanExecuteChanged() {
			CommandManager.InvalidateRequerySuggested();
		}


		public event EventHandler CanExecuteChanged {
			add { CommandManager.RequerySuggested += value; }
			remove { CommandManager.RequerySuggested -= value; }
		}
	}
}
