using Messenger.Services;
using System;

namespace Messenger.UseCases
{
	class AcceptMessage
	{
		private readonly IMessengerService messengerService;

		public AcceptMessage(IMessengerService messengerService)
		{
			this.messengerService = messengerService ?? throw new ArgumentNullException(nameof(messengerService));
		}

		public void Execute(AcceptMessageRequest request)
		{
			messengerService.SendMessage(GetMessageDto(request));
		}

		private MessageDto GetMessageDto(AcceptMessageRequest req)
		{
			return new MessageDto()
			{
				MessageText = req.MessageText,
				RequireConfirmation = req.RequireConfirmation
			};
		}
	}
}
