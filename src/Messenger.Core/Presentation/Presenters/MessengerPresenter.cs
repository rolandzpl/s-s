using Messenger.Presentation.Commands;
using Messenger.Presentation.ViewModels;
using Messenger.UseCases;
using System;

namespace Messenger.Presentation.Presenters
{
	class MessengerPresenter
	{
		private readonly IPresentationCore context;
		private readonly AcceptMessage acceptMessage;
		private MessageViewModel viewModel;
		private IView view;

		public MessengerPresenter(IPresentationCore context, AcceptMessage acceptMessage)
		{
			this.context = context ?? throw new ArgumentNullException(nameof(context));
			this.acceptMessage = acceptMessage ?? throw new ArgumentNullException(nameof(acceptMessage));
		}

		public void Show()
		{
			view = context.CreateView();
			viewModel = new MessageViewModel(
				new DelegatedCommand(OnExecuteOkCommand, OnCanExecuteOkCommand),
				new DelegatedCommand(OnExecuteCancelCommand, OnCanExecuteCancelCommand));
			view.Show(viewModel);
		}

		private bool OnCanExecuteCancelCommand()
		{
			return true;
		}

		private bool OnCanExecuteOkCommand()
		{
			return true;
		}

		private void OnExecuteOkCommand()
		{
			acceptMessage.Execute(CreateRequest(viewModel));
			view.Close();
		}

		private AcceptMessageRequest CreateRequest(MessageViewModel vm)
		{
			return new AcceptMessageRequest()
			{
				MessageText = vm.Message,
				RequireConfirmation = vm.RequireConfirmation,
			};
		}

		private void OnExecuteCancelCommand()
		{
			view.Close();
		}
	}
}
