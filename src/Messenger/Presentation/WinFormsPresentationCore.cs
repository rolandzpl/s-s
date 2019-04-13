using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Messenger.Presentation
{
	class WinFormsPresentationCore : IPresentationCore
	{
		private readonly Dictionary<Type, Type> mappings = new Dictionary<Type, Type>();
		private readonly Control shell;

		public WinFormsPresentationCore(Control shell)
		{
			this.shell = shell ?? throw new ArgumentNullException(nameof(shell));
		}

		public void RegisterView(Type viewModelType, Type viewType)
		{
			mappings.Add(viewModelType, viewType);
		}

		public IView CreateView(Type viewModelType)
		{
			Type viewType;
			if(!mappings.TryGetValue(viewModelType, out viewType))
			{
				throw new ViewModelTypeUnknownException();
			}
			var ctor = viewType.GetConstructor(Type.EmptyTypes);
			var ctrl = (Control)ctor.Invoke(null);
			ctrl.Parent = shell;
			ctrl.Dock = DockStyle.Fill;
			return (IView)ctrl;
		}
	}
}
