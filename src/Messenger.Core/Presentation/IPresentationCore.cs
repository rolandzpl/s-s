using Messenger.Presentation.ViewModels;

namespace Messenger.Presentation
{
	public interface IPresentationCore
	{
		void Show(ViewModelBase viewModel);

		IView CreateView();
	}
}