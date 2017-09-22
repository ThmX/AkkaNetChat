using Akka.Actor;
using Akka.Event;

namespace ChatServer
{
  public class Bridge : UntypedActor
  {
    private readonly ILoggingAdapter _log = Context.GetLogger();

    protected override void OnReceive(object message)
    {
      switch (message)
      {
        case "ping":
          _log.Info($"ping from {Sender}");
          Sender.Tell("pong");
          break;


        case "pong":
          _log.Info($"pong from {Sender}");
          break;

        default:
          Unhandled(message);
          break;
      }
    }
  }
}
