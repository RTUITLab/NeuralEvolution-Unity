using Grpc.Core;
using UnityEngine;

public class Client
{
    private readonly LearnBoar.LearnBoarClient _client;
    private readonly Channel _channel;
    private readonly string _server = "127.0.0.1:5000";

    internal Client()
    {
        _channel = new Channel(_server, ChannelCredentials.Insecure);
        _client = new LearnBoar.LearnBoarClient(_channel);
    }

    internal Action SendData(EnvData new_data)
    {
        Action action = _client.SendData(new_data);
        return action;
    }

    internal AgentId CreateAgent(AgentData data)
    {
        AgentId agent = _client.CreateAgent(data);
        return agent;
    }

    private void OnDisable()
    {
        _channel.ShutdownAsync().Wait();
    }
}
