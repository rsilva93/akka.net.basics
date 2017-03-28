using System;

namespace Shared
{
    public class SimpleMessage
    {
        public SimpleMessage(DateTime date, string content)
        {
            Date = date;
            Content = content;
        }

        public DateTime Date { get; }
        public string Content { get; }
    }
}
