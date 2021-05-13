using System;
using System.Collections.Generic;
using System.Text;

namespace Ex3
{
    public class Skype : InstantMessenger
    {

        public Skype(IMessagingService instantMessenger) : base(instantMessenger) { }
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
