# AkkaNetChat
Simple Ping-Pong with Akka.Remote in .NET Core 2.

## Build
```bash
$ cd AkkaNetChat
$ dotnet restore
$ dotnet build
```

## Run Client
```bash
$ cd AkkaNetChat/ChatServer
$ dotnet run
```

## Run Server
```bash
$ cd AkkaNetChat/ChatClient
$ dotnet run
```

## .NET Core 2
```
thmx@thmx AkkaChat $ dotnet --info
.NET Command Line Tools (2.0.0)

Product Information:
 Version:            2.0.0
 Commit SHA-1 hash:  cdcd1928c9

Runtime Environment:
 OS Name:     Mac OS X
 OS Version:  10.12
 OS Platform: Darwin
 RID:         osx.10.12-x64
 Base Path:   /usr/local/share/dotnet/sdk/2.0.0/

Microsoft .NET Core Shared Framework Host

  Version  : 2.0.0
  Build    : e8b8861ac7faf042c87a5c2f9f2d04c98b69f28d
```

## Server
```
/usr/local/share/dotnet/dotnet /Users/thmx/AkkaChat/ChatServer/bin/Debug/netcoreapp2.0/ChatServer.dll
[DEBUG][9/22/17 8:06:12 AM][Thread 0002][EventStream] subscribing [akka://all-systems/] to channel Akka.Event.Debug
[DEBUG][9/22/17 8:06:12 AM][Thread 0002][EventStream] subscribing [akka://all-systems/] to channel Akka.Event.Info
[DEBUG][9/22/17 8:06:12 AM][Thread 0002][EventStream] subscribing [akka://all-systems/] to channel Akka.Event.Warning
[DEBUG][9/22/17 8:06:12 AM][Thread 0002][EventStream] subscribing [akka://all-systems/] to channel Akka.Event.Error
[DEBUG][9/22/17 8:06:12 AM][Thread 0002][EventStream] StandardOutLogger started
[DEBUG][9/22/17 8:06:12 AM][Thread 0003][akka://chat-server/] Started (Akka.Actor.GuardianActor)
[DEBUG][9/22/17 8:06:12 AM][Thread 0004][akka://chat-server/user] Started (Akka.Actor.GuardianActor)
[DEBUG][9/22/17 8:06:12 AM][Thread 0003][akka://chat-server/] now supervising akka://chat-server/user
[DEBUG][9/22/17 8:06:12 AM][Thread 0005][akka://chat-server/system] Started (Akka.Actor.SystemGuardianActor)
[DEBUG][9/22/17 8:06:12 AM][Thread 0003][akka://chat-server/] now supervising akka://chat-server/system
[DEBUG][9/22/17 8:06:12 AM][Thread 0006][akka://chat-server/user] now watched by [akka://chat-server/system]
[DEBUG][9/22/17 8:06:12 AM][Thread 0005][akka://chat-server/system] now watched by [akka://chat-server/]
[DEBUG][9/22/17 8:06:12 AM][Thread 0003][akka://chat-server/system/log1-DefaultLogger] Started (Akka.Event.DefaultLogger)
[DEBUG][9/22/17 8:06:12 AM][Thread 0004][akka://chat-server/system] now supervising akka://chat-server/system/log1-DefaultLogger
[DEBUG][9/22/17 8:06:12 AM][Thread 0002][EventStream] subscribing [akka://chat-server/system/log1-DefaultLogger#1222571399] to channel Akka.Event.Debug
[DEBUG][9/22/17 8:06:12 AM][Thread 0002][EventStream] subscribing [akka://chat-server/system/log1-DefaultLogger#1222571399] to channel Akka.Event.Info
[DEBUG][9/22/17 8:06:12 AM][Thread 0002][EventStream] subscribing [akka://chat-server/system/log1-DefaultLogger#1222571399] to channel Akka.Event.Warning
[DEBUG][9/22/17 8:06:12 AM][Thread 0002][EventStream] subscribing [akka://chat-server/system/log1-DefaultLogger#1222571399] to channel Akka.Event.Error
[DEBUG][9/22/17 8:06:12 AM][Thread 0002][EventStream(chat-server)] Logger log1-DefaultLogger [DefaultLogger] started
[DEBUG][9/22/17 8:06:12 AM][Thread 0002][EventStream] subscribing [akka://chat-server/system/log1-DefaultLogger#1222571399] to channel Akka.Event.Debug
[DEBUG][9/22/17 8:06:12 AM][Thread 0002][EventStream] subscribing [akka://chat-server/system/log1-DefaultLogger#1222571399] to channel Akka.Event.Info
[DEBUG][9/22/17 8:06:12 AM][Thread 0002][EventStream] subscribing [akka://chat-server/system/log1-DefaultLogger#1222571399] to channel Akka.Event.Warning
[DEBUG][9/22/17 8:06:12 AM][Thread 0002][EventStream] subscribing [akka://chat-server/system/log1-DefaultLogger#1222571399] to channel Akka.Event.Error
[DEBUG][9/22/17 8:06:12 AM][Thread 0002][EventStream(chat-server)] Logger log1-DefaultLogger [DefaultLogger] started
[DEBUG][9/22/17 8:06:12 AM][Thread 0002][EventStream] subscribing [akka://chat-server/system/UnhandledMessageForwarder#1149142414] to channel Akka.Event.UnhandledMessage
[DEBUG][9/22/17 8:06:12 AM][Thread 0006][akka://chat-server/system] now supervising akka://chat-server/system/UnhandledMessageForwarder
[DEBUG][9/22/17 8:06:12 AM][Thread 0002][EventStream(chat-server)] StandardOutLogger being removed
[DEBUG][9/22/17 8:06:12 AM][Thread 0006][akka://chat-server/system/UnhandledMessageForwarder] Started (Akka.Event.LoggingBus+UnhandledMessageForwarder)
[DEBUG][9/22/17 8:06:12 AM][Thread 0002][EventStream] subscribing [akka://chat-server/system/UnhandledMessageForwarder#1149142414] to channel Akka.Event.UnhandledMessage
[DEBUG][9/22/17 8:06:12 AM][Thread 0006][akka://chat-server/system] now supervising akka://chat-server/system/UnhandledMessageForwarder
[DEBUG][9/22/17 8:06:12 AM][Thread 0002][EventStream(chat-server)] StandardOutLogger being removed
[DEBUG][9/22/17 8:06:12 AM][Thread 0006][akka://chat-server/system/UnhandledMessageForwarder] Started (Akka.Event.LoggingBus+UnhandledMessageForwarder)
[DEBUG][9/22/17 8:06:12 AM][Thread 0002][EventStream] unsubscribing [akka://all-systems/] from all channels
[DEBUG][9/22/17 8:06:12 AM][Thread 0002][EventStream] unsubscribing [akka://all-systems/] from all channels
[DEBUG][9/22/17 8:06:12 AM][Thread 0002][EventStream(chat-server)] Default Loggers started
[DEBUG][9/22/17 8:06:12 AM][Thread 0003][akka://chat-server/system] now supervising akka://chat-server/system/remoting-terminator
[DEBUG][9/22/17 8:06:12 AM][Thread 0003][akka://chat-server/system] now supervising akka://chat-server/system/transports
[INFO][9/22/17 8:06:12 AM][Thread 0002][remoting] Starting remoting
[DEBUG][9/22/17 8:06:12 AM][Thread 0005][akka://chat-server/system] now supervising akka://chat-server/system/endpointManager
[DEBUG][9/22/17 8:06:12 AM][Thread 0008][akka://chat-server/system/remoting-terminator] Started (Akka.Remote.RemoteActorRefProvider+RemotingTerminator)
[DEBUG][9/22/17 8:06:12 AM][Thread 0008][akka://chat-server/system/remoting-terminator] now watched by [akka://chat-server/system]
[DEBUG][9/22/17 8:06:12 AM][Thread 0003][akka://chat-server/system/transports] Started (Akka.Remote.TransportSupervisor)
[DEBUG][9/22/17 8:06:12 AM][Thread 0009][remoting] Starting prune timer for endpoint manager...
[DEBUG][9/22/17 8:06:12 AM][Thread 0009][akka://chat-server/system/endpointManager] Started (Akka.Remote.EndpointManager)
[DEBUG][9/22/17 8:06:12 AM][Thread 0011][akka://chat-server/system/transports/akkaprotocolmanager.tcp.0] Started (Akka.Remote.Transport.AkkaProtocolManager)
[DEBUG][9/22/17 8:06:12 AM][Thread 0003][akka://chat-server/system/transports] now supervising akka://chat-server/system/transports/akkaprotocolmanager.tcp.0
[INFO][9/22/17 8:06:12 AM][Thread 0002][remoting] Remoting started; listening on addresses : [akka.tcp://chat-server@localhost:8081]
[INFO][9/22/17 8:06:12 AM][Thread 0002][remoting] Remoting now listens on addresses: [akka.tcp://chat-server@localhost:8081]
[DEBUG][9/22/17 8:06:12 AM][Thread 0003][akka://chat-server/system] now supervising akka://chat-server/system/remote-watcher
[DEBUG][9/22/17 8:06:12 AM][Thread 0005][akka://chat-server/system] now supervising akka://chat-server/system/remote-deployment-watcher
[DEBUG][9/22/17 8:06:12 AM][Thread 0004][akka://chat-server/system] now supervising akka://chat-server/system/deadLetterListener
[DEBUG][9/22/17 8:06:12 AM][Thread 0010][akka://chat-server/system/remote-deployment-watcher] Started (Akka.Remote.RemoteDeploymentWatcher)
[DEBUG][9/22/17 8:06:12 AM][Thread 0003][akka://chat-server/system] now supervising akka://chat-server/system/EventStreamUnsubscriber-1
[DEBUG][9/22/17 8:06:12 AM][Thread 0003][EventStreamUnsubscriber] registering unsubscriber with Akka.Event.EventStream
[DEBUG][9/22/17 8:06:12 AM][Thread 0004][EventStream] subscribing [akka://chat-server/system/deadLetterListener#913317376] to channel Akka.Event.DeadLetter
[DEBUG][9/22/17 8:06:12 AM][Thread 0004][akka://chat-server/system/deadLetterListener] Started (Akka.Event.DeadLetterListener)
[DEBUG][9/22/17 8:06:12 AM][Thread 0011][akka://chat-server/system/remote-watcher] Started (Akka.Remote.RemoteWatcher)
[DEBUG][9/22/17 8:06:12 AM][Thread 0003][akka://chat-server/system/EventStreamUnsubscriber-1] Started (Akka.Event.EventStreamUnsubscriber)
[INFO][9/22/17 8:06:12 AM][Thread 0002][ActorSystem(chat-server)]   akka : {
    stdout-loglevel : DEBUG
    loglevel : DEBUG
    log-config-on-start : on
    actor : {
      debug : {
        receive : on
        autoreceive : on
        lifecycle : on
        event-stream : on
        unhandled : on
      }
      provider : "Akka.Remote.RemoteActorRefProvider, Akka.Remote"
      serializers : {
        hyperion : "Akka.Serialization.HyperionSerializer, Akka.Serialization.Hyperion"
      }
      serialization-bindings : {
        System.Object : hyperion
      }
    }
    remote : {
      log-remote-lifecycle-events : on
      log-received-messages : on
      dot-netty : {
        tcp : {
          port : 8081
          hostname : 0.0.0.0
          public-hostname : localhost
        }
      }
    }
  }

[DEBUG][9/22/17 8:06:12 AM][Thread 0005][akka://chat-server/user] now supervising akka://chat-server/user/bridge
[DEBUG][9/22/17 8:06:12 AM][Thread 0006][akka://chat-server/user/bridge] Started (ChatServer.Bridge)
[DEBUG][9/22/17 8:06:15 AM][Thread 0010][akka://chat-server/system/transports/akkaprotocolmanager.tcp.0] now supervising akka://chat-server/system/transports/akkaprotocolmanager.tcp.0/akkaProtocol-tcp%3A%2F%2Fchat-server%40%5B%3A%3Affff%3A127.0.0.1%5D%3A58893-1
[DEBUG][9/22/17 8:06:15 AM][Thread 0011][akka://chat-server/system/transports/akkaprotocolmanager.tcp.0/akkaProtocol-tcp%3A%2F%2Fchat-server%40%5B%3A%3Affff%3A127.0.0.1%5D%3A58893-1] Started (Akka.Remote.Transport.ProtocolStateActor)
[DEBUG][9/22/17 8:06:15 AM][Thread 0010][remoting] Associated [akka.tcp://chat-server@localhost:8081] <- akka.tcp://chat-client@localhost:8082
[DEBUG][9/22/17 8:06:15 AM][Thread 0010][akka://chat-server/system/endpointManager] now supervising akka://chat-server/system/endpointManager/reliableEndpointWriter-akka.tcp%3A%2F%2Fchat-client%40localhost%3A8082-1
[DEBUG][9/22/17 8:06:16 AM][Thread 0011][akka://chat-server/system/endpointManager/reliableEndpointWriter-akka.tcp%3A%2F%2Fchat-client%40localhost%3A8082-1] Started (Akka.Remote.ReliableDeliverySupervisor)
[DEBUG][9/22/17 8:06:16 AM][Thread 0011][akka://chat-server/system/endpointManager/reliableEndpointWriter-akka.tcp%3A%2F%2Fchat-client%40localhost%3A8082-1] now watched by [akka://chat-server/system/endpointManager#403225694]
[DEBUG][9/22/17 8:06:16 AM][Thread 0011][akka://chat-server/system/endpointManager/reliableEndpointWriter-akka.tcp%3A%2F%2Fchat-client%40localhost%3A8082-1] now supervising akka://chat-server/system/endpointManager/reliableEndpointWriter-akka.tcp%3A%2F%2Fchat-client%40localhost%3A8082-1/endpointWriter
[DEBUG][9/22/17 8:06:16 AM][Thread 0008][akka://chat-server/system/endpointManager/reliableEndpointWriter-akka.tcp%3A%2F%2Fchat-client%40localhost%3A8082-1/endpointWriter] Started (Akka.Remote.EndpointWriter)
[DEBUG][9/22/17 8:06:16 AM][Thread 0008][akka://chat-server/system/endpointManager/reliableEndpointWriter-akka.tcp%3A%2F%2Fchat-client%40localhost%3A8082-1/endpointWriter] now watched by [akka://chat-server/system/endpointManager/reliableEndpointWriter-akka.tcp%3A%2F%2Fchat-client%40localhost%3A8082-1#891993816]
[DEBUG][9/22/17 8:06:16 AM][Thread 0008][akka://chat-server/system/endpointManager/reliableEndpointWriter-akka.tcp%3A%2F%2Fchat-client%40localhost%3A8082-1/endpointWriter] now supervising akka://chat-server/system/endpointManager/reliableEndpointWriter-akka.tcp%3A%2F%2Fchat-client%40localhost%3A8082-1/endpointWriter/endpointReader-akka.tcp%3A%2F%2Fchat-client%40localhost%3A8082-1
[DEBUG][9/22/17 8:06:16 AM][Thread 0009][akka://chat-server/system/endpointManager/reliableEndpointWriter-akka.tcp%3A%2F%2Fchat-client%40localhost%3A8082-1/endpointWriter/endpointReader-akka.tcp%3A%2F%2Fchat-client%40localhost%3A8082-1] Started (Akka.Remote.EndpointReader)
[DEBUG][9/22/17 8:06:16 AM][Thread 0009][akka://chat-server/system/endpointManager/reliableEndpointWriter-akka.tcp%3A%2F%2Fchat-client%40localhost%3A8082-1/endpointWriter/endpointReader-akka.tcp%3A%2F%2Fchat-client%40localhost%3A8082-1] now watched by [akka://chat-server/system/endpointManager/reliableEndpointWriter-akka.tcp%3A%2F%2Fchat-client%40localhost%3A8082-1/endpointWriter#261882133]
[DEBUG][9/22/17 8:06:16 AM][Thread 0011][[akka://chat-server/system/endpointManager/reliableEndpointWriter-akka.tcp%3A%2F%2Fchat-client%40localhost%3A8082-1/endpointWriter#261882133]] received local message [RemoteMessage: ActorSelectionMessage - Message: <Identify>:  - WildCartFanOut: False - Elements: user/bridge to [akka://chat-server/]<+akka://chat-server/ from [akka.tcp://chat-client@localhost:8082/temp/d]]
[DEBUG][9/22/17 8:06:16 AM][Thread 0003][akka://chat-server/user/bridge] received AutoReceiveMessage <Identify>: 
[DEBUG][9/22/17 8:06:21 AM][Thread 0009][[akka://chat-server/system/endpointManager/reliableEndpointWriter-akka.tcp%3A%2F%2Fchat-client%40localhost%3A8082-1/endpointWriter#261882133]] received local message [RemoteMessage: ping to [akka://chat-server/user/bridge#920637175]<+akka://chat-server/user/bridge from [akka.tcp://chat-client@localhost:8082/user/bridge#1880157187]]
[INFO][9/22/17 8:06:21 AM][Thread 0006][[akka://chat-server/user/bridge#920637175]] ping from [akka.tcp://chat-client@localhost:8082/user/bridge#1880157187]
```

## Client
```
/usr/local/share/dotnet/dotnet /Users/thmx/AkkaChat/ChatClient/bin/Debug/netcoreapp2.0/ChatClient.dll
[DEBUG][9/22/17 8:06:14 AM][Thread 0002][EventStream] subscribing [akka://all-systems/] to channel Akka.Event.Debug
[DEBUG][9/22/17 8:06:15 AM][Thread 0002][EventStream] subscribing [akka://all-systems/] to channel Akka.Event.Info
[DEBUG][9/22/17 8:06:15 AM][Thread 0002][EventStream] subscribing [akka://all-systems/] to channel Akka.Event.Warning
[DEBUG][9/22/17 8:06:15 AM][Thread 0002][EventStream] subscribing [akka://all-systems/] to channel Akka.Event.Error
[DEBUG][9/22/17 8:06:15 AM][Thread 0002][EventStream] StandardOutLogger started
[DEBUG][9/22/17 8:06:15 AM][Thread 0003][akka://chat-client/] Started (Akka.Actor.GuardianActor)
[DEBUG][9/22/17 8:06:15 AM][Thread 0005][akka://chat-client/system] Started (Akka.Actor.SystemGuardianActor)
[DEBUG][9/22/17 8:06:15 AM][Thread 0004][akka://chat-client/user] Started (Akka.Actor.GuardianActor)
[DEBUG][9/22/17 8:06:15 AM][Thread 0003][akka://chat-client/] now supervising akka://chat-client/user
[DEBUG][9/22/17 8:06:15 AM][Thread 0003][akka://chat-client/] now supervising akka://chat-client/system
[DEBUG][9/22/17 8:06:15 AM][Thread 0005][akka://chat-client/system] now watched by [akka://chat-client/]
[DEBUG][9/22/17 8:06:15 AM][Thread 0004][akka://chat-client/user] now watched by [akka://chat-client/system]
[DEBUG][9/22/17 8:06:15 AM][Thread 0005][akka://chat-client/system/log1-DefaultLogger] Started (Akka.Event.DefaultLogger)
[DEBUG][9/22/17 8:06:15 AM][Thread 0006][akka://chat-client/system] now supervising akka://chat-client/system/log1-DefaultLogger
[DEBUG][9/22/17 8:06:15 AM][Thread 0002][EventStream] subscribing [akka://chat-client/system/log1-DefaultLogger#1317492911] to channel Akka.Event.Debug
[DEBUG][9/22/17 8:06:15 AM][Thread 0002][EventStream] subscribing [akka://chat-client/system/log1-DefaultLogger#1317492911] to channel Akka.Event.Info
[DEBUG][9/22/17 8:06:15 AM][Thread 0002][EventStream] subscribing [akka://chat-client/system/log1-DefaultLogger#1317492911] to channel Akka.Event.Warning
[DEBUG][9/22/17 8:06:15 AM][Thread 0002][EventStream] subscribing [akka://chat-client/system/log1-DefaultLogger#1317492911] to channel Akka.Event.Error
[DEBUG][9/22/17 8:06:15 AM][Thread 0002][EventStream(chat-client)] Logger log1-DefaultLogger [DefaultLogger] started
[DEBUG][9/22/17 8:06:15 AM][Thread 0002][EventStream] subscribing [akka://chat-client/system/log1-DefaultLogger#1317492911] to channel Akka.Event.Debug
[DEBUG][9/22/17 8:06:15 AM][Thread 0002][EventStream] subscribing [akka://chat-client/system/log1-DefaultLogger#1317492911] to channel Akka.Event.Info
[DEBUG][9/22/17 8:06:15 AM][Thread 0002][EventStream] subscribing [akka://chat-client/system/UnhandledMessageForwarder#1889003055] to channel Akka.Event.UnhandledMessage
[DEBUG][9/22/17 8:06:15 AM][Thread 0002][EventStream] subscribing [akka://chat-client/system/log1-DefaultLogger#1317492911] to channel Akka.Event.Warning
[DEBUG][9/22/17 8:06:15 AM][Thread 0002][EventStream(chat-client)] StandardOutLogger being removed
[DEBUG][9/22/17 8:06:15 AM][Thread 0002][EventStream] subscribing [akka://chat-client/system/log1-DefaultLogger#1317492911] to channel Akka.Event.Error
[DEBUG][9/22/17 8:06:15 AM][Thread 0002][EventStream(chat-client)] Logger log1-DefaultLogger [DefaultLogger] started
[DEBUG][9/22/17 8:06:15 AM][Thread 0002][EventStream] subscribing [akka://chat-client/system/UnhandledMessageForwarder#1889003055] to channel Akka.Event.UnhandledMessage
[DEBUG][9/22/17 8:06:15 AM][Thread 0002][EventStream(chat-client)] StandardOutLogger being removed
[DEBUG][9/22/17 8:06:15 AM][Thread 0006][akka://chat-client/system/UnhandledMessageForwarder] Started (Akka.Event.LoggingBus+UnhandledMessageForwarder)
[DEBUG][9/22/17 8:06:15 AM][Thread 0006][akka://chat-client/system/UnhandledMessageForwarder] Started (Akka.Event.LoggingBus+UnhandledMessageForwarder)
[DEBUG][9/22/17 8:06:15 AM][Thread 0002][EventStream] unsubscribing [akka://all-systems/] from all channels
[DEBUG][9/22/17 8:06:15 AM][Thread 0002][EventStream] unsubscribing [akka://all-systems/] from all channels
[DEBUG][9/22/17 8:06:15 AM][Thread 0004][akka://chat-client/system] now supervising akka://chat-client/system/UnhandledMessageForwarder
[DEBUG][9/22/17 8:06:15 AM][Thread 0004][akka://chat-client/system] now supervising akka://chat-client/system/UnhandledMessageForwarder
[DEBUG][9/22/17 8:06:15 AM][Thread 0002][EventStream(chat-client)] Default Loggers started
[DEBUG][9/22/17 8:06:15 AM][Thread 0005][akka://chat-client/system] now supervising akka://chat-client/system/remoting-terminator
[DEBUG][9/22/17 8:06:15 AM][Thread 0005][akka://chat-client/system] now supervising akka://chat-client/system/transports
[INFO][9/22/17 8:06:15 AM][Thread 0002][remoting] Starting remoting
[DEBUG][9/22/17 8:06:15 AM][Thread 0006][akka://chat-client/system] now supervising akka://chat-client/system/endpointManager
[DEBUG][9/22/17 8:06:15 AM][Thread 0010][akka://chat-client/system/remoting-terminator] Started (Akka.Remote.RemoteActorRefProvider+RemotingTerminator)
[DEBUG][9/22/17 8:06:15 AM][Thread 0010][akka://chat-client/system/remoting-terminator] now watched by [akka://chat-client/system]
[DEBUG][9/22/17 8:06:15 AM][Thread 0005][akka://chat-client/system/transports] Started (Akka.Remote.TransportSupervisor)
[DEBUG][9/22/17 8:06:15 AM][Thread 0009][remoting] Starting prune timer for endpoint manager...
[DEBUG][9/22/17 8:06:15 AM][Thread 0009][akka://chat-client/system/endpointManager] Started (Akka.Remote.EndpointManager)
[DEBUG][9/22/17 8:06:15 AM][Thread 0011][akka://chat-client/system/transports/akkaprotocolmanager.tcp.0] Started (Akka.Remote.Transport.AkkaProtocolManager)
[DEBUG][9/22/17 8:06:15 AM][Thread 0003][akka://chat-client/system/transports] now supervising akka://chat-client/system/transports/akkaprotocolmanager.tcp.0
[INFO][9/22/17 8:06:15 AM][Thread 0002][remoting] Remoting started; listening on addresses : [akka.tcp://chat-client@localhost:8082]
[INFO][9/22/17 8:06:15 AM][Thread 0002][remoting] Remoting now listens on addresses: [akka.tcp://chat-client@localhost:8082]
[DEBUG][9/22/17 8:06:15 AM][Thread 0005][akka://chat-client/system] now supervising akka://chat-client/system/remote-watcher
[DEBUG][9/22/17 8:06:15 AM][Thread 0006][akka://chat-client/system] now supervising akka://chat-client/system/remote-deployment-watcher
[DEBUG][9/22/17 8:06:15 AM][Thread 0005][akka://chat-client/system] now supervising akka://chat-client/system/deadLetterListener
[DEBUG][9/22/17 8:06:15 AM][Thread 0005][EventStream] subscribing [akka://chat-client/system/deadLetterListener#1338088462] to channel Akka.Event.DeadLetter
[DEBUG][9/22/17 8:06:15 AM][Thread 0005][akka://chat-client/system/deadLetterListener] Started (Akka.Event.DeadLetterListener)
[DEBUG][9/22/17 8:06:15 AM][Thread 0008][akka://chat-client/system/remote-deployment-watcher] Started (Akka.Remote.RemoteDeploymentWatcher)
[DEBUG][9/22/17 8:06:15 AM][Thread 0011][akka://chat-client/system/remote-watcher] Started (Akka.Remote.RemoteWatcher)
[DEBUG][9/22/17 8:06:15 AM][Thread 0006][akka://chat-client/system] now supervising akka://chat-client/system/EventStreamUnsubscriber-1
[DEBUG][9/22/17 8:06:15 AM][Thread 0005][EventStreamUnsubscriber] registering unsubscriber with Akka.Event.EventStream
[DEBUG][9/22/17 8:06:15 AM][Thread 0005][akka://chat-client/system/EventStreamUnsubscriber-1] Started (Akka.Event.EventStreamUnsubscriber)
[INFO][9/22/17 8:06:15 AM][Thread 0002][ActorSystem(chat-client)]   akka : {
    stdout-loglevel : DEBUG
    loglevel : DEBUG
    log-config-on-start : on
    actor : {
      debug : {
        receive : on
        autoreceive : on
        lifecycle : on
        event-stream : on
        unhandled : on
      }
      provider : "Akka.Remote.RemoteActorRefProvider, Akka.Remote"
      serializers : {
        hyperion : "Akka.Serialization.HyperionSerializer, Akka.Serialization.Hyperion"
      }
      serialization-bindings : {
        System.Object : hyperion
      }
    }
    remote : {
      log-remote-lifecycle-events : on
      log-received-messages : on
      dot-netty : {
        tcp : {
          port : 8082
          hostname : 0.0.0.0
          public-hostname : localhost
        }
      }
    }
  }

[DEBUG][9/22/17 8:06:15 AM][Thread 0004][akka://chat-client/user] now supervising akka://chat-client/user/bridge
[DEBUG][9/22/17 8:06:15 AM][Thread 0003][akka://chat-client/user/bridge] Started (ChatServer.Bridge)
[DEBUG][9/22/17 8:06:15 AM][Thread 0010][akka://chat-client/system/endpointManager] now supervising akka://chat-client/system/endpointManager/reliableEndpointWriter-akka.tcp%3A%2F%2Fchat-server%40localhost%3A8081-1
[DEBUG][9/22/17 8:06:15 AM][Thread 0009][akka://chat-client/system/endpointManager/reliableEndpointWriter-akka.tcp%3A%2F%2Fchat-server%40localhost%3A8081-1] Started (Akka.Remote.ReliableDeliverySupervisor)
[DEBUG][9/22/17 8:06:15 AM][Thread 0009][akka://chat-client/system/endpointManager/reliableEndpointWriter-akka.tcp%3A%2F%2Fchat-server%40localhost%3A8081-1] now watched by [akka://chat-client/system/endpointManager#819253848]
[DEBUG][9/22/17 8:06:15 AM][Thread 0009][akka://chat-client/system/endpointManager/reliableEndpointWriter-akka.tcp%3A%2F%2Fchat-server%40localhost%3A8081-1] now supervising akka://chat-client/system/endpointManager/reliableEndpointWriter-akka.tcp%3A%2F%2Fchat-server%40localhost%3A8081-1/endpointWriter
[DEBUG][9/22/17 8:06:15 AM][Thread 0008][akka://chat-client/system/endpointManager/reliableEndpointWriter-akka.tcp%3A%2F%2Fchat-server%40localhost%3A8081-1/endpointWriter] Started (Akka.Remote.EndpointWriter)
[DEBUG][9/22/17 8:06:15 AM][Thread 0008][akka://chat-client/system/endpointManager/reliableEndpointWriter-akka.tcp%3A%2F%2Fchat-server%40localhost%3A8081-1/endpointWriter] now watched by [akka://chat-client/system/endpointManager/reliableEndpointWriter-akka.tcp%3A%2F%2Fchat-server%40localhost%3A8081-1#388225074]
[DEBUG][9/22/17 8:06:15 AM][Thread 0011][akka://chat-client/system/transports/akkaprotocolmanager.tcp.0] now supervising akka://chat-client/system/transports/akkaprotocolmanager.tcp.0/akkaProtocol-tcp%3A%2F%2Fchat-server%40localhost%3A8081-1
[DEBUG][9/22/17 8:06:15 AM][Thread 0010][akka://chat-client/system/transports/akkaprotocolmanager.tcp.0/akkaProtocol-tcp%3A%2F%2Fchat-server%40localhost%3A8081-1] Started (Akka.Remote.Transport.ProtocolStateActor)
[DEBUG][9/22/17 8:06:16 AM][Thread 0009][[akka://chat-client/system/endpointManager/reliableEndpointWriter-akka.tcp%3A%2F%2Fchat-server%40localhost%3A8081-1/endpointWriter#1510124893]] Associated [akka.tcp://chat-client@localhost:8082] -> akka.tcp://chat-server@localhost:8081
[DEBUG][9/22/17 8:06:16 AM][Thread 0011][akka://chat-client/system/endpointManager/reliableEndpointWriter-akka.tcp%3A%2F%2Fchat-server%40localhost%3A8081-1/endpointWriter/endpointReader-akka.tcp%3A%2F%2Fchat-server%40localhost%3A8081-1] Started (Akka.Remote.EndpointReader)
[DEBUG][9/22/17 8:06:16 AM][Thread 0011][akka://chat-client/system/endpointManager/reliableEndpointWriter-akka.tcp%3A%2F%2Fchat-server%40localhost%3A8081-1/endpointWriter/endpointReader-akka.tcp%3A%2F%2Fchat-server%40localhost%3A8081-1] now watched by [akka://chat-client/system/endpointManager/reliableEndpointWriter-akka.tcp%3A%2F%2Fchat-server%40localhost%3A8081-1/endpointWriter#1510124893]
[DEBUG][9/22/17 8:06:16 AM][Thread 0009][[akka://chat-client/system/endpointManager/reliableEndpointWriter-akka.tcp%3A%2F%2Fchat-server%40localhost%3A8081-1/endpointWriter#1510124893]] Drained buffer with maxWriteCount: 50, fullBackoffCount: 1,smallBackoffCount: 0, noBackoffCount: 0,adaptiveBackoff: 1000
[DEBUG][9/22/17 8:06:16 AM][Thread 0009][akka://chat-client/system/endpointManager/reliableEndpointWriter-akka.tcp%3A%2F%2Fchat-server%40localhost%3A8081-1/endpointWriter] now supervising akka://chat-client/system/endpointManager/reliableEndpointWriter-akka.tcp%3A%2F%2Fchat-server%40localhost%3A8081-1/endpointWriter/endpointReader-akka.tcp%3A%2F%2Fchat-server%40localhost%3A8081-1
[DEBUG][9/22/17 8:06:16 AM][Thread 0008][[akka://chat-client/system/endpointManager/reliableEndpointWriter-akka.tcp%3A%2F%2Fchat-server%40localhost%3A8081-1/endpointWriter#1510124893]] received local message [RemoteMessage: <ActorIdentity>: [akka.tcp://chat-server@localhost:8081/user/bridge#920637175] - MessageId= to [akka://chat-client/temp/d]<+akka://chat-client/temp/d from [akka.tcp://chat-server@localhost:8081/user/bridge#920637175]]
```
