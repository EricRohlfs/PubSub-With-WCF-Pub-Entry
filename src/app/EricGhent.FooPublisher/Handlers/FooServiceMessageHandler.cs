using EricGhent.FooModels;
using NServiceBus;

namespace EricGhent.FooPublisher.Handlers
{
    /// <summary>
    /// It causes problems when you have two IHandleMessages of T that are the same type.
    /// Since I have a new type FooServiceMessage that is based on FooMessage, there is not a conflict.
    /// Yes you have to map or cast the service type to it's base, but there are worse things in the world.
    /// </summary>
    public class FooServiceMessageHandler : IHandleMessages<FooServiceMessage>
    {
        public IBus Bus { get; private set; }

        public FooServiceMessageHandler(IBus bus)
        {
            Bus = bus;
        }

        public void Handle(FooServiceMessage message)
        {
            var msgOut = Map(message);
            Bus.Publish(msgOut);
            Bus.Return(0);
        }

        /// <summary>
        /// Need to put this under test.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public FooMessage Map(FooServiceMessage message)
        {
             FooMessage msgOut = (FooMessage) message;
            //casting does not pick up our sub objects, so we can add them back in.
            msgOut.Addresses = message.Addresses;
            return msgOut;
        }

    }
}
