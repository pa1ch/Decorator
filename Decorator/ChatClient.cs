using System;

namespace Decorator
{
    public class ChatClient
    {
        public void SendMessage(BaseMessage message)
        {
            Console.WriteLine(message);
            Console.WriteLine("=======");
        }
        
        public void ReceiveMessage(BaseMessage message)
        {
            Console.WriteLine(message);
            Console.WriteLine("=======");
        }
    }
}