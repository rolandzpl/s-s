using System;

namespace Messenger.Presentation
{
	public interface ICommand
	{
		bool CanExecute();

		void Execute();

		event EventHandler CanExecuteChanged;
	}
}