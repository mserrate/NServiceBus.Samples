using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NServiceBus;

namespace Mutators
{
    public class Initialization : IWantCustomInitialization
    {
        public void Init()
        {
            Configure.Instance.Configurer.ConfigureComponent<TransportEncryptionMutator>(
                DependencyLifecycle.InstancePerCall);
        }
    }
}
