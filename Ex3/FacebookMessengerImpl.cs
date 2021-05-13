using System;
using System.Collections.Generic;
using System.Text;

namespace Ex3
{
    class FacebookMessengerImpl : IMessagingService
    {
        public void SendFile()
        {
            Console.WriteLine("Send file from Facebook");
        }

        public void SendMessage()
        {
            Console.WriteLine("Send message from Facebook");
        }

        public void VideoCall()
        {
            Console.WriteLine("Video call from Facebook");
        }

        public void VoiceCall()
        {
            Console.WriteLine("Voice call from Facebook");
        }
    }
}
