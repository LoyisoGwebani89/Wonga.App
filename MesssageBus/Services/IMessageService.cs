using MessageClient.Models;

namespace MessageClient.Services
{
    public interface IMessageService
    {
        void Send(MessageModel message);
        void Subscribe(MessageModel message);
    }
}