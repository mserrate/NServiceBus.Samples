using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NServiceBus;

namespace Messages
{
    public class MessageWithImage : IMessage
    {
        public string MyProperty { get; set; }
        public DataBusProperty<System.Drawing.Image> Image { get; set; }
    }
}
