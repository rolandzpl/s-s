using System.Collections.Generic;
using System.Linq;

namespace Messenger.Services
{
	public class InMemoryMessageDefinitionService : IMessageDefinitionService
	{
		private List<MessageDefinitionDto> items = new List<MessageDefinitionDto>();

		public IEnumerable<MessageDefinitionDto> GetFavoriteMessages()
		{
			return items.Where(x => x.IsFavorite).ToList();
		}

		public IEnumerable<MessageDefinitionDto> GetMessageDefinitions()
		{
			return items.ToList();
		}

		public void SaveMessageDefinition(MessageDefinitionDto messageDefinition)
		{
			items.RemoveAll(x => x.Id == messageDefinition.Id);
			items.Add(messageDefinition);
		}
	}
}
