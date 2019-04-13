using Messenger.Presentation.ViewModels;
using System;

namespace Messenger.Presentation.Presenters
{
	public class StartViewPresenter
	{
		private readonly IPresentationCore context;
		private StartViewViewModel viewModel;
		private IView view;

		public StartViewPresenter(IPresentationCore context)
		{
			this.context = context ?? throw new ArgumentNullException(nameof(context));
		}

		public void Show()
		{
			view = context.CreateView(typeof(StartViewViewModel));
			viewModel = new StartViewViewModel();
			view.Show(viewModel);
		}
	}
}
