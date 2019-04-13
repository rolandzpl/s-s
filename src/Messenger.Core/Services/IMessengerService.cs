namespace Messenger.Services
{
	public interface IMessengerService
	{
		void SendMessage(MessageDto messageDto);
	}
}