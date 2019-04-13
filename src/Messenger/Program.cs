using Messenger.Presentation;
using Messenger.Presentation.ViewModels;
using Messenger.Services;
using Messenger.UseCases;
using Messenger.Views;
using System;
using System.Windows.Forms;

namespace Messenger
{
	static class Program
	{
		[STAThread]
		static void Main()
		{
			Application.SetCompatibleTextRenderingDefault(false);
			var messengerService = new InMemoryMessengerService();
			var shell = new Shell();
			var presentationCore = new WinFormsPresentationCore(shell);
			presentationCore.RegisterView(typeof(StartViewViewModel), typeof(StartView));
			var uc = new ShowStartScreen(presentationCore);
			uc.Execute();
			Application.EnableVisualStyles();
			Application.Run(shell);
		}
	}
}
