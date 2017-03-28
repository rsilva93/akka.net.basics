using Akka.Actor;
using Shared;
using System;

namespace Echo
{
    public class WriterActor : ReceiveActor
    {
        public WriterActor()
        {
            Receive<SimpleMessage>(message =>
            {
                Console.WriteLine(message.ToString());
            });

            Receive<EchoMessage>(message =>
            {
                Console.WriteLine(message.ToString());
                Context.Sender.Tell(new SimpleMessage(message.Content));
            });
        }
    }
}