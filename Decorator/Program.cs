using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new ChatClient();
            
            var message = new SimpleMessage("me", "you", "hi");
            var encodedMessage = new MessageDecoratorBuilder(message).EncodeMessage().Build();
            var hidingUser = new MessageDecoratorBuilder(message).HideUsers().Build();
            var encodedMessageWithHidingUsers = new MessageDecoratorBuilder(message)
                .EncodeMessage().HideUsers().Build();
            
            client.SendMessage(message);
            client.SendMessage(encodedMessage);
            client.SendMessage(hidingUser);
            client.SendMessage(encodedMessageWithHidingUsers);
            client.ReceiveMessage(new DecodeMessageDecorator(encodedMessage));
        }
    }
}