using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Messenger.Presentation.ViewModels
{
	public class MessageViewModel : ViewModelBase
	{
		private ICommand okCommand;
		private readonly ICommand cancelCommand;
		private readonly ObservableCollection<DefinedMessageViewModel> definedMessages =
			new ObservableCollection<DefinedMessageViewModel>();
		private bool requireConfirmation;
		private string message;

		public MessageViewModel(ICommand okCommand, ICommand cancelCommand)
		{
			this.okCommand = okCommand ?? throw new System.ArgumentNullException(nameof(okCommand));
			this.cancelCommand = cancelCommand ?? throw new System.ArgumentNullException(nameof(cancelCommand));
		}

		public string Message
		{
			get { return message; }
			set { SetValue(ref message, value, nameof(Message)); }
		}

		public bool RequireConfirmation
		{
			get { return requireConfirmation; }
			set { SetValue(ref requireConfirmation, value, nameof(RequireConfirmation)); }
		}

		public IEnumerable<DefinedMessageViewModel> DefinedMessages
		{
			get { return definedMessages; }
		}
	}
}