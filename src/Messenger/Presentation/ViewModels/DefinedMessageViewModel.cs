using System;

namespace Messenger.Presentation.ViewModels
{
	public class DefinedMessageViewModel : ViewModelBase
	{
		private Guid id;
		private string messageText;
		private bool isFavorite;
		private ImageRef imageRef;
		private TimeSpan? printSpan;

		public Guid Id
		{
			get { return id; }
			set { SetValue(ref id, value, nameof(Id)); }
		}

		public string MessageText
		{
			get { return messageText; }
			set { SetValue(ref messageText, value, nameof(MessageText)); }
		}

		public bool IsFavorite
		{
			get { return isFavorite; }
			set { SetValue(ref isFavorite, value, nameof(IsFavorite)); }
		}

		public ImageRef Image
		{
			get { return imageRef; }
			set { SetValue(ref imageRef, value, nameof(Image)); }
		}

		public TimeSpan? PrintSpan
		{
			get { return printSpan; }
			set { SetValue(ref printSpan, value, nameof(PrintSpan)); }
		}
	}
}