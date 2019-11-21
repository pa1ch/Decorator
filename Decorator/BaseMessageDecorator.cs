namespace Decorator
{
    public abstract class BaseMessageDecorator : BaseMessage
    {
        protected BaseMessage message;

        protected BaseMessageDecorator(string author, string recipient, string text, BaseMessage baseMessage) : 
            base(author, recipient, text)
        {
            message = baseMessage;
        }
    }
}