using System;
using MessageClient.Enums;

namespace MessageClient.Models
{
    public class MessageModel
    {
        public MessageType Type { get; set; }
        public Action<string> MessageHandler { get; set; }
        public string Name { get; set; }
    }
}