using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NServiceBus;
using Messages;

namespace Client
{
    public class Main : IWantToRunAtStartup
    {
        public IBus Bus { get; set; }

        public void Run()
        {
            Bus.Send<SampleMessage>(m =>
                {
                    m.MyProperty = "Testing Property";
                    m.MyNumber = 55;
                });
        }

        public void Stop()
        {
        }
    }
}
