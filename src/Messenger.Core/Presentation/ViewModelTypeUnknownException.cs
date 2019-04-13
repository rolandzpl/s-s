using System;
using System.Runtime.Serialization;

namespace Messenger.Presentation
{
	[Serializable]
	public class ViewModelTypeUnknownException : Exception
	{
		public ViewModelTypeUnknownException()
		{
		}

		public ViewModelTypeUnknownException(string message) : base(message)
		{
		}

		public ViewModelTypeUnknownException(string message, Exception innerException) : base(message, innerException)
		{
		}

		protected ViewModelTypeUnknownException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}