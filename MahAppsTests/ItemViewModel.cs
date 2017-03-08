using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;


namespace MahAppsTests
{
	public class ItemViewModel : INotifyPropertyChanged
	{
		public static string Command1Name {
			get { return "Command 1"; }
		}

		public static string Command2Name {
			get { return "Command 2"; }
		}


		private static int nextNameIndex = 1;


		public ItemViewModel() {
			Name = $"Item {++ItemViewModel.nextNameIndex}";

			Command1 = new DelegateCommand(
					arg => {
						MessageBox.Show("Command 1");
					});
			Command2 = new DelegateCommand(
					arg => {
						MessageBox.Show("Command 2");
					});
		}


		public string Name { get; }


		public ICommand Command1 { get; }

		public ICommand Command2 { get; }


		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
