using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EricGhent.FooModels;
using NServiceBus;

namespace EricGhent.FooPublisher.WebServices
{
    public class FooServiceMessageService: WcfService<FooServiceMessage,ErrorCodes>
    {
    }
}
