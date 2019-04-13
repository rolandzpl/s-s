using Messenger.Presentation.ViewModels;
using System;

namespace Messenger.Presentation
{
	public interface IPresentationCore
	{
		IView CreateView(Type viewModelType);
	}
}