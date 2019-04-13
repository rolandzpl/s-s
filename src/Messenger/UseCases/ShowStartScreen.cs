using Messenger.Presentation;
using Messenger.Presentation.Presenters;
using Messenger.Services;

namespace Messenger.UseCases
{
	public class ShowStartScreen
	{
		private IPresentationCore presentationCore;

		public ShowStartScreen(IPresentationCore presentationCore)
		{
			this.presentationCore = presentationCore ?? throw new System.ArgumentNullException(nameof(presentationCore));
		}

		public void Execute()
		{
			var presenter = new StartViewPresenter(presentationCore);
			presenter.Show();
		}
	}
}
