using Messenger.Presentation.ViewModels;

namespace Messenger
{
	public interface IView
	{
		void Show(ViewModelBase viewModel);

		void Close();
	}
}