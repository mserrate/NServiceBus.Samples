using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NServiceBus;
using Messages;
using System.Drawing;
using System.IO;

namespace Server
{
    public class MessageWithImageHandler : IHandleMessages<MessageWithImage>
    {
        public void Handle(MessageWithImage message)
        {
            Image img = message.Image.Value;
        }
    }
}
