using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NServiceBus;

namespace Messages
{
    public class SampleMessage : IMessage
    {
        public string MyProperty { get; set; }
        public int MyNumber { get; set; }
    }
}
