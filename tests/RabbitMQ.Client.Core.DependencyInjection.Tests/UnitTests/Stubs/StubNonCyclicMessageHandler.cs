using System;
using RabbitMQ.Client.Core.DependencyInjection.MessageHandlers;
using RabbitMQ.Client.Core.DependencyInjection.Services;

namespace RabbitMQ.Client.Core.DependencyInjection.Tests.UnitTests.Stubs
{
    internal class StubNonCyclicMessageHandler : INonCyclicMessageHandler
    {
        public void Handle(string message, string routingKey, IQueueService queueService)
        {
            Console.WriteLine($"{message}:{routingKey}:{queueService.GetType()}");
        }
    }
}