using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NServiceBus;
using Messages;

namespace Server
{
    public class SampleMessageHandler : IHandleMessages<SampleMessage>
    {
        public void Handle(SampleMessage message)
        {
            // process the message
        }
    }
}
