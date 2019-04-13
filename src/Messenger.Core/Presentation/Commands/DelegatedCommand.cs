using System;

namespace Messenger.Presentation.Commands
{
	internal class DelegatedCommand : ICommand
	{
		private readonly Action execute;
		private readonly Func<bool> canExecute;

		public DelegatedCommand(Action execute, Func<bool> canExecute)
		{
			this.execute = execute ?? throw new ArgumentNullException(nameof(execute));
			this.canExecute = canExecute ?? throw new ArgumentNullException(nameof(canExecute));
		}

		public event EventHandler CanExecuteChanged;

		public bool CanExecute()
		{
			return canExecute();
		}

		public void Execute()
		{
			execute();
		}
	}
}