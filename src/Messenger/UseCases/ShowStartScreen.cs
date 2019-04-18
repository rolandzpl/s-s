using Messenger.Presentation;
using Messenger.Presentation.Presenters;
using Messenger.Services;

namespace Messenger.UseCases
{
	public class ShowStartScreen
	{
		private IPresentationCore presentationCore;
		private IMessageDefinitionService messageDefinitionService;

		public ShowStartScreen(
			IPresentationCore presentationCore, 
			IMessageDefinitionService messageDefinitionService)
		{
			this.presentationCore = presentationCore ?? throw new System.ArgumentNullException(nameof(presentationCore));
			this.messageDefinitionService = messageDefinitionService ?? throw new System.ArgumentNullException(nameof(messageDefinitionService));
		}

		public void Execute()
		{
			var presenter = new StartViewPresenter(presentationCore, messageDefinitionService);
			presenter.Show();
		}
	}
}
