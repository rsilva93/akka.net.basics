namespace Shared
{
    public class EchoMessage : BaseMessage
    {
        public EchoMessage(string content) : base(content) { }

        public override string ToString()
        {
            return base.ToString() + " (echo)";
        }
    }
}