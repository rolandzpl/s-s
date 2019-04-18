using System.Collections.Generic;

namespace Messenger.Presentation.ViewModels
{
	public class StartViewViewModel : ViewModelBase
	{
		private DefinedMessageViewModel selectedDefinedMessages;
		private DefinedMessageViewModel selectedFavoriteMessage;
		private IEnumerable<DefinedMessageViewModel> definedMessages;
		private IEnumerable<DefinedMessageViewModel> favoriteMessages;
		private CommandViewModel sendFavoriteMessage;
		private CommandViewModel openDefinedMessage;

		public StartViewViewModel(
			IEnumerable<DefinedMessageViewModel> definedMessages,
			IEnumerable<DefinedMessageViewModel> favoriteMessages)
		{
			this.definedMessages = definedMessages ?? throw new System.ArgumentNullException(nameof(definedMessages));
			this.favoriteMessages = favoriteMessages ?? throw new System.ArgumentNullException(nameof(favoriteMessages));
		}

		public DefinedMessageViewModel SelectedDefinedMessages
		{
			get { return selectedDefinedMessages; }
			set { SetValue(ref selectedDefinedMessages, value, nameof(SelectedDefinedMessages)); }
		}

		public IEnumerable<DefinedMessageViewModel> DefinedMessages
		{
			get { return definedMessages; }
		}

		public DefinedMessageViewModel SelectedFavoriteMessage
		{
			get { return selectedFavoriteMessage; }
			set { SetValue(ref selectedFavoriteMessage, value, nameof(SelectedFavoriteMessage)); }
		}

		public IEnumerable<DefinedMessageViewModel> FavoriteMessages
		{
			get { return favoriteMessages; }
		}
	}
}
