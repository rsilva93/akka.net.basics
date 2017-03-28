using Akka.Actor;
using Shared;
using System;

namespace Writer
{
    public class WriterActor : ReceiveActor
    {
        public WriterActor()
        {
            Receive<SimpleMessage>(message =>
            {
                Console.WriteLine($"{message.Date.ToString("dd/MM/yyyy hh:mm:dd")}: {message.Content}");
            });
        }
    }
}