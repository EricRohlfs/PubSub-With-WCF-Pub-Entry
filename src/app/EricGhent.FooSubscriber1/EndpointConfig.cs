﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NServiceBus;

namespace EricGhent.FooSubscriber1
{
   public class EndpointConfig: IConfigureThisEndpoint,AsA_Server, IWantCustomInitialization
    {
       public void Init()
       {
           Configure.With()
                //this overrides the NServiceBus default convention of IEvent
                .DefiningEventsAs(t => t.Namespace != null && t.Namespace.StartsWith("EricGhent.FooModels"));}
       }
    }

