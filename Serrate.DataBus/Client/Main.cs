using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NServiceBus;
using Messages;
using System.Drawing;
using System.IO;

namespace Client
{
    public class Main : IWantToRunAtStartup
    {
        public IBus Bus { get; set; }

        public void Run()
        {
            var img = Image.FromFile("..\\..\\img\\Tulips.png");

            Bus.Send<MessageWithImage>(m =>
            {
                m.MyProperty = "Message with image file ";
                m.Image = new DataBusProperty<Image>(img);
            });
        }

        public void Stop()
        {
        }
    }
}
