using System;
using System.IO;
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

            var bridge = actorSystem.ActorOf<Bridge>("bridge-on-client");

            // PONG works
            //actorSystem.ActorSelection("akka.tcp://chat-server@127.0.0.1:8081/user/bridge-on-server")
            //    .Tell("ping", bridge);

            // PONG works
            // [INFO][22.09.2017 09:21:36][Thread 0007][[akka://chat-server/user/bridge-on-server#1010445981]] ping from [akka.tcp://chat-client@127.0.0.1:8082/user/bridge-on-client#178647232]
            // [INFO][22.09.2017 09:21:36][Thread 0004][[akka://chat-client/user/bridge-on-client#178647232]] pong from [akka.tcp://chat-server@127.0.0.1:8081/user/bridge-on-server#1010445981]
            //actorSystem.ActorSelection("akka.tcp://chat-server@127.0.0.1:8081/user/bridge-on-server")
            //    .ResolveOne(TimeSpan.FromMinutes(1))
            //    .Result
            //    .Tell("ping", bridge);


            // PONG is not received, even though Sender ActorRef looks correct.
            // [INFO][22.09.2017 09:23:09][Thread 0008][[akka://chat-server/user/bridge-on-server#1632056570]] ping from [akka.tcp://chat-client@127.0.0.1:8082/user/bridge-on-client#1270833092]
            // WHERE IS THE PONG???
            var remoteRef = await actorSystem.ActorSelection("akka.tcp://chat-server@127.0.0.1:8081/user/bridge-on-server")
                .ResolveOne(TimeSpan.FromMinutes(1));
            remoteRef.Tell("ping", bridge);

            Console.ReadLine();
        }
    }
}
