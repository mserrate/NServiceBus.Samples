using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NServiceBus.MessageMutator;
using NServiceBus.Unicast.Transport;

namespace Mutators
{
    public class TransportEncryptionMutator : IMutateTransportMessages
    {
        public void MutateIncoming(TransportMessage transportMessage)
        {
            var decrypt = EncryptionHelper.Decrypt(transportMessage.Body);

            transportMessage.Body = decrypt;
        }

        public void MutateOutgoing(object[] messages, TransportMessage transportMessage)
        {
            var encrypt = EncryptionHelper.Encrypt(transportMessage.Body);

            transportMessage.Body = encrypt;
        }
    }
}
