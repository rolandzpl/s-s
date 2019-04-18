using System;
using System.Collections.Generic;
using System.Text;

namespace Messenger.Services
{
	public interface IMessageDefinitionService
	{
		void SaveMessageDefinition(MessageDefinitionDto messageDefinition);

		IEnumerable<MessageDefinitionDto> GetMessageDefinitions();

		IEnumerable<MessageDefinitionDto> GetFavoriteMessages();
	}
}
