namespace Decorator
{
    public class MessageDecoratorBuilder
    {
        private BaseMessage message;

        public MessageDecoratorBuilder(BaseMessage message)
        {
            this.message = message;
        }
        
        public MessageDecoratorBuilder EncodeMessage()
        {
            message = new EncodeMessageDecorator(message);
            return this;
        }
        
        public MessageDecoratorBuilder DecodeMessage()
        {
            message = new DecodeMessageDecorator(message);
            return this;
        }
        public MessageDecoratorBuilder HideUsers()
        {
            message = new HidingUsersDecorator(message);
            return this;
        }
        
        public BaseMessage Build()
        {
            return message;
        }
    }
}