using Messenger.Presentation;
using Messenger.Presentation.Presenters;
using Messenger.Services;

namespace Messenger.UseCases
{
	public class ShowMessenger
	{
		private IPresentationCore presentationCore;
		private IMessengerService messengerService;

		public ShowMessenger(IPresentationCore presentationCore, IMessengerService messengerService)
		{
			this.presentationCore = presentationCore ?? throw new System.ArgumentNullException(nameof(presentationCore));
			this.messengerService = messengerService ?? throw new System.ArgumentNullException(nameof(messengerService));
		}

		public void Execute()
		{
			var presenter = new MessengerPresenter(presentationCore, new AcceptMessage(messengerService));
			presenter.Show();
		}
	}
}
