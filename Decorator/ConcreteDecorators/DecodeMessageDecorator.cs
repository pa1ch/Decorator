using System;
using System.Text.RegularExpressions;

namespace Decorator
{
    public class DecodeMessageDecorator : BaseMessageDecorator
    {
        public DecodeMessageDecorator(BaseMessage message)
            : base(message.author, message.recipient, message.text.Substring(8, message.text.Length - 9), message)
        { }
    }
}