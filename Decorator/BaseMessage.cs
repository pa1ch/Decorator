namespace Decorator
{
    public abstract class BaseMessage
    {
        public string author;
        public string recipient;
        public string text;
        
        protected BaseMessage(string author, string recipient, string text)
        {
            this.author = author;
            this.recipient = recipient;
            this.text = text;
        }

        public override string ToString()
        {
            return "Author: " + author +
                   "\nRecipient: " + recipient +
                   "\nText: " + text;
        }
    }
}