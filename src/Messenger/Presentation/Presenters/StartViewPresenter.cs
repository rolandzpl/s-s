using Messenger.Presentation.ViewModels;
using Messenger.Services;
using System;
using System.Linq;

namespace Messenger.Presentation.Presenters
{
	public class StartViewPresenter
	{
		private readonly IPresentationCore context;
		private IMessageDefinitionService messageDefinitionService;
		private StartViewViewModel viewModel;
		private IView view;

		public StartViewPresenter(
			IPresentationCore context,
			IMessageDefinitionService messageDefinitionService)
		{
			this.context = context ?? throw new ArgumentNullException(nameof(context));
			this.messageDefinitionService = messageDefinitionService ?? throw new ArgumentNullException(nameof(messageDefinitionService));
		}

		public void Show()
		{
			view = context.CreateView(typeof(StartViewViewModel));
			var favorites = messageDefinitionService.GetFavoriteMessages()
				.Select(x => new DefinedMessageViewModel()
				{
					MessageText = x.MessageText
				})
				.ToList();
			var defined = messageDefinitionService.GetMessageDefinitions()
				.Select(x => new DefinedMessageViewModel()
				{
					MessageText = x.MessageText
				})
				.ToList();
			viewModel = new StartViewViewModel(defined, favorites);
			view.Show(viewModel);
		}
	}
}
