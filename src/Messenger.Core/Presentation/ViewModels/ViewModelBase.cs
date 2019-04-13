using System.ComponentModel;

namespace Messenger.Presentation.ViewModels
{
	public class ViewModelBase : INotifyPropertyChanged
	{
		protected void SetValue<T>(ref T target, T value, string propertyName)
		{
			target = value;
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}