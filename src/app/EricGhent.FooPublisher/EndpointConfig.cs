using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NServiceBus;

namespace EricGhent.FooPublisher
{

    internal class EndpointConfig: IConfigureThisEndpoint, AsA_Publisher
    {
    }
}
