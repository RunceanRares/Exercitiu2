using System;
using System.Collections.Generic;
using System.Text;

namespace Ex3
{
    public class SkypeImpl : IMessagingService
    {
        public void SendFile()
        {
            Console.WriteLine("Send file from Skype");
        }

        public void SendMessage()
        {
            Console.WriteLine("Send message from Skype");
        }

        public void VideoCall()
        {
            Console.WriteLine("Video call from Skype");
        }

        public void VoiceCall()
        {
            Console.WriteLine("Voice call from Skype");
        }
    }
}
