using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using MediatR;
using MicroserviceRabbitmq.Domain.Core.Bus;
using MicroserviceRabbitmq.Domain.Core.Events;

namespace ConsoleApp1
{
    class HelloEvent : Event
    {
        public string Message { get; set; }

        public HelloEvent(string message)
        {
            Message = message;
        }
    }

    class HelloEventHandle1 : IEventHandler<HelloEvent>
    {
        public Task Handle(HelloEvent @event)
        {
            Console.WriteLine($"HelloEventHandler1 receive message: {@event.Message}");
            return Task.CompletedTask;
        }
    }

    class Program
    {
        static void Main()
        {
            var subscription = typeof(HelloEventHandle1);
            var handler = Activator.CreateInstance(subscription);

            var eventType = typeof(HelloEvent);
            var @event = new HelloEvent("Hello");
            var concreteType = typeof(IEventHandler<>).MakeGenericType(eventType);
            
            
            concreteType.GetMethod("Handle").Invoke(handler, new object[] {@event});
        }
    }
}