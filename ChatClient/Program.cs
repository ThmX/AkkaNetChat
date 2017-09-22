using System;
using System.IO;
using Akka.Actor;
using Akka.Configuration;
using ChatServer;

namespace ChatClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var configStr = File.ReadAllText("application.conf");
            var config = ConfigurationFactory.ParseString(configStr);
            var actorSystem = ActorSystem.Create("chat-client", config);

            var bridge = actorSystem.ActorOf<Bridge>("bridge");

            actorSystem.ActorSelection("akka.tcp://chat-server@127.0.0.1:8081/user/bridge")
                .Tell("ping", bridge);

            Console.ReadLine();
        }
    }
}
