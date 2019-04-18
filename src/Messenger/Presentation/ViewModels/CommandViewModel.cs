namespace Messenger.Presentation.ViewModels
{
	internal class CommandViewModel : ViewModelBase
	{
		private string text;
		private ICommand command;

		public string Text
		{
			get { return text; }
		}

		public ICommand Command
		{
			get { return command; }
		}
	}
}