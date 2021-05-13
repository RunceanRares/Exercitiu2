using System;
using System.Collections.Generic;
using System.Text;

namespace Ex3
{
    public abstract class InstantMessenger //: IInstantMessenger
    {
        protected IMessagingService messagingService;
         
        protected InstantMessenger(IMessagingService messagingService)
        {
            this.messagingService = messagingService;
        }
        //public void SendFile()
        //{
        //    Console.WriteLine("Send file");
        //}

        //public void SendMessage()
        //{
        //    Console.WriteLine("Send message");
        //}

        public abstract void SendFile();
        public abstract void SendMessage();
    }
}
