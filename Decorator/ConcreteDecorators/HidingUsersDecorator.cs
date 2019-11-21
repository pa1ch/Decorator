namespace Decorator
{
    public class HidingUsersDecorator : BaseMessageDecorator
    {
        public HidingUsersDecorator(BaseMessage message)
            : base("ENCODED[" + message.author + "]", "ENCODED[" + message.recipient + "]", message.text, message )
        { }
    }
}