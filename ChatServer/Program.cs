using System;
using System.IO;
using System.Threading;
using Akka.Actor;
using Akka.Configuration;

namespace ChatServer
{
  class Program
  {
    static void Main(string[] args)
    {
      var configStr = File.ReadAllText("application.conf");
      var config = ConfigurationFactory.ParseString(configStr);
      var actorSystem = ActorSystem.Create("chat-server", config);

      var bridge = actorSystem.ActorOf<Bridge>("bridge");

      for (;;)
      {
        Thread.Sleep(TimeSpan.FromSeconds(1));
      }

      actorSystem.Terminate().Wait();
    }
  }
}
