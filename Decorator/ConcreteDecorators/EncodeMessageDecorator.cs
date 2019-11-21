namespace Decorator
{
    public class EncodeMessageDecorator : BaseMessageDecorator
    {
        public EncodeMessageDecorator(BaseMessage message)
        : base(message.author, message.recipient,"ENCODED[" + message.text + "]", message )
        { }
    }
}