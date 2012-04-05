using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EricGhent.FooModels;
using NServiceBus;

namespace EricGhent.FooSubscriber1
{
    public class EventMessageHandler: IHandleMessages<FooMessage>
    {
        public void Handle(FooMessage message)
        {
            //Implement custom logic here for you subscriber event.  Usually push data into external system.
            Console.WriteLine("FooMessage arrived");
        }
    }
}
