namespace GrechkaChat
{
    public class Message
    {
        public string sender { get; private set; }

        public string message_context { get; private set; }

        public Message(string sender, string context)
        {
            this.sender = sender;
            this.message_context = context;
        }
    }
}