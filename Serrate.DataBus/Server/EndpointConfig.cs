using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NServiceBus;
using System.Configuration;

namespace Server
{
    public class EndpointConfig : IConfigureThisEndpoint, AsA_Server
    {
    }

    public class Initialization : IWantCustomInitialization
    {
        public void Init()
        {
            string basePath = ConfigurationManager.AppSettings["SharedFolder"];

            Configure.Instance
                .FileShareDataBus(basePath)
                .UnicastBus();
        }        
    }
}
