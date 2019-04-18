using System.Windows.Forms;
using Messenger.Presentation.ViewModels;

namespace Messenger.Views
{
	public partial class StartView : UserControl, IView
	{
		public StartView()
		{
			InitializeComponent();
		}

		public void Close()
		{
			Visible = false;
		}

		public void Show(ViewModelBase viewModel)
		{
			StartViewViewModel vm = (StartViewViewModel)viewModel;
			this.lbFavorites.DataSource = vm.FavoriteMessages;
			this.lbFavorites.DisplayMember = nameof(DefinedMessageViewModel.MessageText);
			this.lbFavorites.ValueMember = nameof(DefinedMessageViewModel.Id);
			Visible = true;
		}
	}
}
