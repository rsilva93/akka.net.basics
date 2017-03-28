using Akka.Actor;
using Shared;

namespace Echo
{
    public class EchoActor : ReceiveActor
    {
        public EchoActor(IActorRef writer)
        {
            Receive<string>(message =>
            {
                writer.Tell(new EchoMessage(message));
            });

            Receive<EchoMessage>(message =>
            {
                writer.Tell(message);
            });

            Receive<SimpleMessage>(message =>
            {
                writer.Tell(message);
            });
        }
    }
}