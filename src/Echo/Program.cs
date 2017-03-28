using Akka.Actor;
using Shared;
using System;
using System.Threading;

namespace Echo
{
    public class Program
    {
        static void Main(string[] args)
        {
            var actorSystem = ActorSystem.Create("some-echo");

            var writerActor = actorSystem.ActorOf<WriterActor>();

            var echoProps = Props.Create(() => new EchoActor(writerActor));

            var echoActor = actorSystem.ActorOf(echoProps);

            Thread.Sleep(1000);

            writerActor.Tell(new SimpleMessage("Let's play. Tell me something. Say 'bye' to give up."));

            var text = Console.ReadLine();

            while (text.ToLower() != "bye")
            {
                echoActor.Tell(text);

                text = Console.ReadLine();
            }

            writerActor.Tell(new SimpleMessage("Bye looser!"));

            actorSystem.WhenTerminated.Wait();
        }
    }
}
