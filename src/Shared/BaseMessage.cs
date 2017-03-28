using System;

namespace Shared
{
    public class BaseMessage
    {
        public BaseMessage(string content)
        {
            Date = DateTime.Now;
            Content = content;
        }
        
        public DateTime Date { get; }
        public string Content { get; }

        public override string ToString()
        {
            return $"{Date.ToString("dd/MM/yyyy hh:mm:dd")}: {Content}";
        }
    }
}
