using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Akka.Actor;
using Akka.Configuration;
using ChatServer;

namespace ChatClient
{
  class Program
  {
    static async Task Main(string[] args)
    {
      var configStr = File.ReadAllText("application.conf");
      var config = ConfigurationFactory.ParseString(configStr);
      var actorSystem = ActorSystem.Create("chat-client", config);

      var timeout = TimeSpan.FromSeconds(5);
      const string remoteUrl = "akka.tcp://chat-server@localhost:8081/user/";

      var bridge = actorSystem.ActorOf<Bridge>("bridge");

      var remoteBridge = await actorSystem.ActorSelection(remoteUrl + "bridge").ResolveOne(timeout);
      
      Thread.Sleep(TimeSpan.FromSeconds(5));

      remoteBridge.Tell("ping", bridge);

      for (;;)
      {
        Thread.Sleep(TimeSpan.FromSeconds(1));
      }

      actorSystem.Terminate().Wait();
    }
  }
}
