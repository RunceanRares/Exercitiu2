using System;
using System.Collections.Generic;
using System.Text;

namespace Ex3
{
    public class WhatsApp : InstantMessenger
    {
        public WhatsApp(IMessagingService instantMessenger) : base(instantMessenger) { }
        public override void SendFile()
        {
            throw new NotImplementedException();
        }

        public override void SendMessage()
        {
            throw new NotImplementedException();
        }
    }
}
