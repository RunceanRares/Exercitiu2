using System;
using System.Collections.Generic;
using System.Text;

namespace Ex3
{
    public class FacebookMessenger : InstantMessenger
    {
        public FacebookMessenger(IMessagingService instantMessenger) : base(instantMessenger) { }

        public override void SendFile()
        {
            messagingService.SendFile();
        }

        public override void SendMessage()
        {
            messagingService.SendMessage();
        }
    }

 
}
