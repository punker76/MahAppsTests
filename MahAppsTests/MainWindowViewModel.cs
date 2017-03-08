using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace MahAppsTests
{
	public class MainWindowViewModel : INotifyPropertyChanged
	{
		public MainWindowViewModel() {
			Items = new ObservableCollection<ItemViewModel> {
				new ItemViewModel(),
				new ItemViewModel(),
				new ItemViewModel(),
				new ItemViewModel(),
				new ItemViewModel()
			};
		}


		public ObservableCollection<ItemViewModel> Items { get; }


		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
