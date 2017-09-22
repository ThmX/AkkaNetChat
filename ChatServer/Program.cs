using System;
using System.IO;
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

            actorSystem.ActorOf<Bridge>("bridge-on-server");

            Console.WriteLine("Server running and waiting...");
            Console.ReadLine();
        }
    }
}
